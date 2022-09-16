﻿using Domain.Models;
using Domain.Repositories;
using Infrastructure.Fakers;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class MapCustomersViewModel : BaseViewModel
    {
        public ICollection<Customer> Customers { get; set; }

        private readonly ICustomerRepository customerRepository;

        public MapCustomersViewModel(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;

            Customers = customerRepository.Get();
        }
    }
}
