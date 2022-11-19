﻿using System;

namespace MyDotnetApp.Web.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public ProductModel()
        {
        }
    }
}

