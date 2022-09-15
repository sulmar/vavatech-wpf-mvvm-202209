using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public int ActiveCustomers { get; set; }
        public decimal EarningAnnual { get; set; }
        public int Tasks { get; set; }
        public int PendingDocuments { get; set; }


        public DashboardViewModel()
        {
            ActiveCustomers = 75;
            EarningAnnual = 200_000;
            Tasks = 10;
            PendingDocuments = 5;
        }
    }
}
