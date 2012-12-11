using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReadsSharp.Models
{
    public class ShelfReview : Review
    {
        public Book Book { get; set; }
        public List<Shelf> Shelves { get; set; }
        public Boolean Owned { get; set; }
    }
}
