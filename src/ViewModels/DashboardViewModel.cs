using Domain.Models;
using Domain.Repositories;

namespace ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public int ActiveCustomers { get; set; }
        public decimal EarningAnnual { get; set; }
        public int Tasks { get; set; }
        public int PendingDocuments { get; set; }

        public ICollection<TaskType> TaskTypes { get; private set; }

        public DashboardViewModel(ITaskTypeRepository taskTypeRepository)
        {
            ActiveCustomers = 75;
            EarningAnnual = 200_000;
            Tasks = 10;
            PendingDocuments = 5;

            TaskTypes = taskTypeRepository.Get();
        }
    }
}
