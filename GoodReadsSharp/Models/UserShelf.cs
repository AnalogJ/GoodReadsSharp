using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReadsSharp.Models
{
    public class UserShelf
    {
        public Int32 BookCount { get; set; }
        public String Description { get; set; }
        public Boolean ExclusiveFlag { get; set; }
        public Boolean Featured { get; set; }
        public Int32 Id { get; set; }
        public String Name { get; set; }
        /*
         * <book_count type=\"integer\">3</book_count>
      <description nil=\"true\"/>
      <display_fields>
      </display_fields>
      <exclusive_flag type=\"boolean\">true</exclusive_flag>
      <featured type=\"boolean\">true</featured>
      <id type=\"integer\">28684905</id>
      <name>read</name>
      <order nil=\"true\"/>
      <per_page type=\"integer\" nil=\"true\"/>
      <recommend_for type=\"boolean\">true</recommend_for>
      <sort nil=\"true\"/>
      <sticky type=\"boolean\" nil=\"true\"/>
         */
    }
}
