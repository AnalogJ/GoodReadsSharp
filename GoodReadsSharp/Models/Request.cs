using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReadsSharp.Models
{
    public class Request
    {
        public String Authentication { get; set; }
        public String Key { get; set; }
        public String Method { get; set; }
    }
}
