using ProductDAL;
using ProductDAL.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductMVC.ViewModels
{
    public class ProductVM
    {
        
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime purchaseDate { get; set; }
        public DateTime ExpDate { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public int CategoryId { get; set; }
        public DateTime MFG { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}
