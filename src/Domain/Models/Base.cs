using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Domain.Models
{
    public abstract class Base : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;
        

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region INotifyDataErrorInfo

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        private readonly IDictionary<string, List<string>> errorsByPropertyName = new Dictionary<string, List<string>>();

        public bool HasErrors => errorsByPropertyName.Any();

        public IEnumerable GetErrors(string? propertyName)
        {
            return errorsByPropertyName.ContainsKey(propertyName) ? errorsByPropertyName[propertyName] : Enumerable.Empty<string>();
        }

        protected void AddError(string propertyName, string error)
        {
            if (!errorsByPropertyName.ContainsKey(propertyName))
                errorsByPropertyName[propertyName] = new List<string>();

            if (!errorsByPropertyName[propertyName].Contains(error))
            {
                errorsByPropertyName[propertyName].Add(error);

                OnErrorsChanged(propertyName);

            }
        }
       

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        System.Collections.IEnumerable INotifyDataErrorInfo.GetErrors(string? propertyName)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}