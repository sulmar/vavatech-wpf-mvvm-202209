﻿namespace Domain.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string Color { get; set; }
    }
}