using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_MVC.Models
{
    public class BookViewModel
    {
        public string BookNumber { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; }
    }
}