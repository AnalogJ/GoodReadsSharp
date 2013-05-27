using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodReadsSharp.ResponseModel;
using RestSharp;

namespace GoodReadsSharp
{
    public partial class GoodReadsClient
    {
        /// <summary>
        /// Returns a list of books owned by the user.
        /// </summary>
        public ListOwnedBooks ListOwnedBooks(Int32 page = 1)
        {

            var request = new RestRequest("owned_books/user", Method.GET);
            request.AddParameter("id", _userLogin.Id);
            
            //request. = DataFormat.Xml;
            if (page > 1)
            {
                request.AddParameter("page", page);
            }

            var response = _restClient.Execute<ListOwnedBooks>(request);

            return response.Data;
        }

        public AddToOwnedBooks AddToOwnedBooks(String bookId)
        {

            var request = new RestRequest("owned_books.xml", Method.POST);

            //Dictionary<String, String> owned_book = new Dictionary<string, string>();
            //owned_book.Add("book_id", bookId);

            request.AddParameter("owned_book[book_id]", bookId);

            var response = _restClient.Execute<AddToOwnedBooks>(request);
            return response.Data;
        }
    }
}
