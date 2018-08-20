using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore_MVC.Models
{
    public class BookViewModel
    {
        public string BookNumber { get; set; }
        [Display(Name = "Book Name")]
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; }
    }
}