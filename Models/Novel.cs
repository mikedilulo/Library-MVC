using System.Collections.Generic;

namespace library.Models
{
  class Novel : Book
  {
    public string MainCharacter { get; private set; }
    public Novel(string mainCharacter, string title, string title1, int pages, string description, string author, bool available) : base(title, title1, pages, description, author, available)
    {
      MainCharacter = mainCharacter;
    }
  }
}

