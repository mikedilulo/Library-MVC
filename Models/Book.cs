namespace library.Models
{
  //NOTE abstrct class because all of them are going to be using the Book Properties to build them
  abstract class Book
  {
    public string Title { get; private set; }
    public int Pages { get; private set; }
    public string Description { get; private set; }
    public string Author { get; private set; }
    public bool Available { get; set; }




    public Book(string title, string title1, int pages, string description, string author, bool available)
    {
      Title = title;
      Pages = pages;
      Description = description;
      Author = author;
      Available = available;
    }
  }
}

//NOTE enum this is a global variable, so it can be placed anywhere. It is just placed in the models page to clean up the code
enum Genre
{
  Adventure,
  Comedy,
  Drama,
  Epic,
  Erotic,
  Nonsense,
  Lyric,
  Mythopoeia,
  Romance,
  Satire,
  Fiction,
  Tragedy,
  TragiComedy
}