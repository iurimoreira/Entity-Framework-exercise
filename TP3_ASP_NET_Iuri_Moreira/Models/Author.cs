using System.Collections.Generic;

namespace TP3_ASP_NET_Iuri_Moreira.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}