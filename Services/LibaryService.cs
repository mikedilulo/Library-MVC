using System.Collections.Generic;
using library.Models;

namespace library.Services
{
  class LibraryService
  {
    private Library Library { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();

    private void Setup()
    {
      Library = new Library("123 N. Main Street", 12003334444);
      Novel lotr = new Novel("Frodo Baggins", "The Lord of the Rings", "The Fellowship of the Ring", 500, "Epic Adventure to Mordor to destroy the ring", "JRR Tolkien");
      Novella starwars = new Novella(35, "Star Wars", "Return of the Jedi", 430, "Epic adventure for Luke Skywalker and Yoda", "George Lucas");
      Short mousey = new Short("Play", "The Mouse Adventures", "The Fellowship of the Mouse", 85, "This is an adventure about a mouse that will head to the depths of the cave to retrieve a medal", "Speedy Gonzalez");
    }



    public void PrintBooks()
    {
      for (int i = 0; i < Library.Books.Count; i++)
      {
        System.Console.WriteLine(Library.Books);
      }
    }
    public LibraryService()
    {
      Setup();
    }
  }
}