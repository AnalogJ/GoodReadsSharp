using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReadsSharp.Models
{
    public class Book
    {
        public String Id { get; set; }
        public String Isbn { get; set; }
        public String Isbn13 { get; set; }
        public Int32 TextReviewsCount { get; set; }
        public String Title { get; set; }
        public String ImageUrl { get; set; }
        public String SmallImageUrl { get; set; }
        public String Link { get; set; }
        public String NumPages { get; set; }
        public String Format { get; set; }
        public String EditionInformation { get; set; }
        public String Publisher { get; set; }
        public String PublicationDay { get; set; }
        public String PublicationYear { get; set; }
        public String PublicationMonth { get; set; }
        public String AverageRating { get; set; }
        public String Description { get; set; }

        public List<Author> Authors { get; set; }

    }
}
