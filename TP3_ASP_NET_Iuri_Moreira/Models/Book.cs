using System.Collections.Generic;

namespace TP3_ASP_NET_Iuri_Moreira.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Isbn { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}