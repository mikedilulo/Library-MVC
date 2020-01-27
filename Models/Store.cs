using System.Collections.Generic;

namespace library.Models
{
  class Store
  {
    public string Address { get; set; }
    public long PhoneNumber { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();

    public Store(string address, long phoneNumber)
    {
      Address = address;
      PhoneNumber = phoneNumber;
    }
  }
}