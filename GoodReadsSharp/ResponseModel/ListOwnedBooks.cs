using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodReadsSharp.Models;

namespace GoodReadsSharp.ResponseModel
{
    public class ListOwnedBooks
    {
        public Request Request { get; set; }
        public List<OwnedBook> OwnedBooks { get; set; }
    }
}
