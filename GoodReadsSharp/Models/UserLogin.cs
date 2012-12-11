using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodReadsSharp.Models
{
    public class UserLogin
    {
        public string Token { get; set; }
        public string Secret { get; set; }
        public string Id { get; set; }

        public UserLogin(String token, String secret)
        {
            Token = token;
            Secret = secret;
            Id = null;
        }
    }
}
