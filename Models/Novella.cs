using System.Collections.Generic;

namespace library.Models
{
  class Novella : Book
  {
    public int Chapters { get; private set; }
    public Novella(int chapters, string title, string title1, int pages, string description, string author) : base(title, title1, pages, description, author)
    {
      Chapters = chapters;
    }
  }
}