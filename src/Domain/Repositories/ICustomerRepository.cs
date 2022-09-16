﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{

    public interface ICustomerRepository : IEntityRepository<Customer>
    {
        Task<ICollection<Customer>> GetAsync();

        //void SendEmail();
        //Task SendEmailAsync(); 
    }


}
