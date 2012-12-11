using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReadsSharp.Models
{
    public class Shelf
    {
        /*
         * <created-at type=\"datetime\">2012-10-31T20:04:09+00:00</created-at>
  <id type=\"integer\">295334468</id>
  <position type=\"integer\">1</position>
  <review-id type=\"integer\">445518110</review-id>
  <updated-at type=\"datetime\">2012-10-31T20:04:09+00:00</updated-at>
  <user-shelf-id type=\"integer\">45484891</user-shelf-id>
  <name>testingquietthyme</name>
         */
        public Int32 Id { get; set; }
        public Int32 Position { get; set; }
        public Int32 ReviewId { get; set; }
        public Int32 UserShelfId { get; set; }
        public String Name { get; set; }
    }
}
