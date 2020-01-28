using library.Models;
using library.Services;


namespace library.Controllers
{
  class LibraryController
  {
    private LibraryService Service { get; set; } = new LibraryService();
    private bool _running = true;

    public void Run()
    {
      while (_running)
      {
        Service.PrintBooks();
      }
    }
  }
}