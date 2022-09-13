using System.Windows.Input;

namespace ViewModels
{

    public class CounterViewModel : BaseViewModel
    {
        // public int CurrentCount { get; set; }

        private int _currentCount;
        public int CurrentCount
        { 
            get
            {
                return _currentCount;
            }
            set
            {
                _currentCount = value;

                // OnPropertyChanged("CurrentCount");

                // OnPropertyChanged(nameof(CurrentCount));

                OnPropertyChanged();
            }
        }

        public ICommand IncrementCountCommand { get; private set; }

        public CounterViewModel()
        {
            CurrentCount = 20;

            IncrementCountCommand = new DelegateCommand(IncrementCount, canExecute: CanIncrementCount);
        }

        private void IncrementCount()
        {
            CurrentCount++;
        }

        private bool CanIncrementCount(object parameter)
        {
            return true;
        }
    }
}