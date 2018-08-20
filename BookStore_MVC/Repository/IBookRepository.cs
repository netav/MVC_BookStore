using BookStore_MVC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_MVC.Repository
{
    interface IBookRepository
    {
        List<Book> GetAll();
        List<Book> GetByRating(double rating);
        List<Book> GetByName(string name);
        Book GetById(int id);

        void AddBook(Book book);
        void RemoveBook(int id);
        void UpdateBook(Book book);
    }
}
