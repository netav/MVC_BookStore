using BookStore_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_MVC.Service
{
    interface IBookService
    {
        List<BookViewModel> GetAll();
        BookViewModel GetById(string bookNumber);
        void AddNewBook(BookViewModel model);
        void RemoveBook(string BookNumber);
        void UpdateBook(BookViewModel model);
    }
}
