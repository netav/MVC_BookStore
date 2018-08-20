using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookStore_MVC.Domain;
using BookStore_MVC.Models;
using BookStore_MVC.Repository;

namespace BookStore_MVC.Service
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        private IHashidsService _hashidsService;

        public BookService()
        {
            _bookRepository = new BookRepository();
            _hashidsService = new HashidsService();
        }

        public void AddNewBook(BookViewModel model)
        {
            Book book = new Book
            {
                Name = model.Name,
                Author = model.Author,
                Rating = model.Rating,
                Price = model.Price
            };
            _bookRepository.AddBook(book);
        }

        public List<BookViewModel> GetAll()
        {
            var books = _bookRepository.GetAll();

            return books.Select(_ => new BookViewModel
            {
                BookNumber = _hashidsService.Encrypt(_.Id),
                Name = _.Name,
                Author = _.Author,
                Price = _.Price,
                Rating = _.Rating
            }).ToList();            
        }

        public BookViewModel GetById(string bookNumber)
        {
            int bookId = _hashidsService.Decrypt(bookNumber);
            Book book = _bookRepository.GetById(bookId);
            return new BookViewModel
            {
                Author = book.Author,
                Name = book.Name,
                Price = book.Price,
                Rating = book.Rating,
                BookNumber = bookNumber
            };
        }

        public void RemoveBook(string BookNumber)
        {
            int bookId = _hashidsService.Decrypt(BookNumber);
            _bookRepository.RemoveBook(bookId);
        }

        public void UpdateBook(BookViewModel model)
        {
            int bookId = _hashidsService.Decrypt(model.BookNumber);

            Book newBook = new Book
            {
                Id = bookId,
                Author = model.Author,
                Name = model.Name,
                Price = model.Price,
                Rating = model.Rating

            };

            _bookRepository.UpdateBook(newBook);
        }
    }
}