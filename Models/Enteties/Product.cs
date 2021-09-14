﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models.Enteties
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? Price { get; set; }

        //Navigational Properties
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}