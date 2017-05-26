using System.Collections.Generic;

namespace Application.Web.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Isbn { get; set; }

        public string Title { get; set; }

        public virtual ICollection<Author> Authors { get; set; }
    }
}