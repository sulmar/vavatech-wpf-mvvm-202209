using Domain.Models;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class InMemoryTaskTypeRepository : ITaskTypeRepository
    {
        private readonly ICollection<TaskType> taskTypes;

        public InMemoryTaskTypeRepository()
        {
            taskTypes = new List<TaskType>
            {
                new TaskType { Id = 1, Name = "Server Migration", Progress = 0.2 },
                new TaskType { Id = 2, Name = "Sales Tracking", Progress = 0.3 },
                new TaskType { Id = 3, Name = "Customer Database", Progress = 0.6 },
                new TaskType { Id = 4, Name = "Payout Details", Progress = 0.8 },
                new TaskType { Id = 5, Name = "Account Setup", Progress = 1.0 },
            };
        }

        public ICollection<TaskType> Get() => taskTypes;
    }
}
