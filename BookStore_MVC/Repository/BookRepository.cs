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

        public Book GetById(int id)
        {
            return _context.Books.FirstOrDefault(_ => _.Id == id);
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
            Book book = _context.Books.FirstOrDefault(_ => _.Id == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book newbook)
        {
            Book oldBook = GetById(newbook.Id);

            oldBook.Name = newbook.Name;
            oldBook.Price = newbook.Price;
            oldBook.Rating = newbook.Rating;
            oldBook.Author = newbook.Author;

            _context.SaveChanges();
        }
    }
}