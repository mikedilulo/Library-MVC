using System;
using library.Controllers;
using library.Models;

namespace library
{
  class Program
  {
    static void Main(string[] args)
    {
      LibraryController lc = new LibraryController();
      lc.Run();
    }
  }
}
