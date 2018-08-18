using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore_MVC.Data;
using BookStore_MVC.Domain;

namespace BookStore_MVC.Repository
{
    public class BookRepository : IBookRepository
    {
        private AppDbContext _context;

        public BookRepository()
        {
            _context = new AppDbContext();
        }
        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return _context.Books.ToList();
        }

        public List<Book> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetByRating(double rating)
        {
            throw new NotImplementedException();
        }

        public void RemoveBook(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}