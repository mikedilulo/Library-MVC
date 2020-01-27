using System.Collections.Generic;

namespace library.Models
{
  class Short : Book
  {
    public string Performance { get; private set; }
    public Short(string performance, string title, string title1, int pages, string description, string author) : base(title, title1, pages, description, author)
    {
      Performance = performance;
    }
  }
}