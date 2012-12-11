using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReadsSharp.Models
{
    public class OwnedBook
    {
        public Int32 CommentsCount { get; set; }
        public Int32 Id { get; set; }
        public String CurrentOwnerId { get; set; }

        public String Link { get; set; }
        public Book Book { get; set; }
        public Review Review { get; set; }
    }
}
