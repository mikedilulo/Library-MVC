using System.Collections.Generic;

namespace library.Models
{
  class Short : Book
  {
    public string Performance { get; private set; }
    public Short(string performance, string title, string title1, int pages, string description, string author, bool available) : base(title, title1, pages, description, author, available)
    {
      Performance = performance;
    }
  }
}