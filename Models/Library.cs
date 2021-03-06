using System;
using System.Collections.Generic;

namespace library.Models
{
  class Library
  {
    public string Address { get; set; }
    public long PhoneNumber { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();

    public void AddBook(Book b)
    {
      Books.Add(b);
    }

    public void AddBook(List<Book> books)
    {
      Books.AddRange(books);
    }






    public Library(string address, long phoneNumber)
    {
      Address = address;
      PhoneNumber = phoneNumber;
    }
  }
}