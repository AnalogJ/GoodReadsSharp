using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReadsSharp.ResponseModel
{
    public class AddToOwnedBooks
    {
        public Boolean AvailableForSwap { get; set; }
        public String BookId { get; set; }
        public Int32 BookTradesCount { get; set; }
        public Int32 CommentsCount { get; set; }
        public Int32 ConditionCode { get; set; }
        public String ConditionDescription { get; set; }
        public String CurrentOwnerId { get; set; }
        public String CurrentOwnerName { get; set; }
        public Int32 Id { get; set; }
        public Int32 ReviewId { get; set; }

        /*
      * <available-for-swap type=\"boolean\">false</available-for-swap>
  <book-id type=\"integer\">944076</book-id>
  <book-trades-count type=\"integer\">0</book-trades-count>
  <comments-count type=\"integer\">0</comments-count>
  <condition-code type=\"integer\" nil=\"true\"/>
  <condition-description nil=\"true\"/>
  <created-at type=\"datetime\">2012-10-31T18:45:40+00:00</created-at>
  <current-owner-id type=\"integer\">8488829</current-owner-id>
  <current-owner-name nil=\"true\"/>
  <id type=\"integer\">10393934</id>
  <last-comment-at type=\"datetime\" nil=\"true\"/>
  <original-purchase-date type=\"datetime\" nil=\"true\"/>
  <original-purchase-location nil=\"true\"/>
  <review-id type=\"integer\">445518110</review-id>
  <swappable-flag type=\"boolean\">false</swappable-flag>
  <unique-code nil=\"true\"/>
  <updated-at type=\"datetime\">2012-10-31T18:45:40+00:00</updated-at>
  <work-id type=\"integer\">929012</work-id>
      */
    }
}
