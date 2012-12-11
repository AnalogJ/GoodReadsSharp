using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodReadsSharp.Models;

namespace GoodReadsSharp.ResponseModel
{
    public class ListBooksOnShelf
    {
        public Request Request { get; set; }
        public List<ShelfReview> Reviews { get; set; }
        public Int32 ReviewsStart { get; set; }
        public String ReviewsEnd { get; set; }
        public Int32 Total { get; set; }

    }

    public class ShelfReviewList : List<ShelfReview>
    {
        public Int32 ReviewsStart { get; set; }
        public String ReviewsEnd { get; set; }
        public Int32 Total { get; set; }
    }
}
