using System.Collections.Generic;

namespace Library.Models
{
  public class Author
  {
    public Author()
    {
      this.AuthorBooks = new HashSet<AuthorBook>();
    }

    public int AuthorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<AuthorBook> AuthorBooks { get; set; }
  }
}