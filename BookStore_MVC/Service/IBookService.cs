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

        void AddNewBook(BookViewModel model);
    }
}
