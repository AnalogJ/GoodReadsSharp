using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoodReadsSharp.Models;
using GoodReadsSharp.ResponseModel;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Contrib;

namespace GoodReadsSharp
{
    public partial class GoodReadsClient
    {
        public String GetTokenAndBuildUrl(string callback = null)
        {
            GetToken();
            return BuildAuthorizeUrl(callback);
        }

        public String BuildAuthorizeUrl(string callbackUrl = null)
        {
            var request = new RestRequest("oauth/authorize");
            request.AddParameter("oauth_token", _userLogin.Token);
            if(!String.IsNullOrEmpty(callbackUrl))
            {
                request.AddParameter("oauth_callback", callbackUrl);
            }
            var url = _restClient.BuildUri(request).ToString();
            return url;
        }


        /// <summary>
        /// Gets a token from goodreads.com (Token cant be used until authorized!)
        /// </summary>
        /// <returns></returns>
        public UserLogin GetToken()
        {
            _restClient = new RestClient(ApiBaseUrl);
            _restClient.Authenticator = OAuth1Authenticator.ForRequestToken(_apiKey, _appsecret);
            var request = new RestRequest("oauth/request_token", Method.GET);
            var response = _restClient.Execute(request);

            var qs = HttpUtility.ParseQueryString(response.Content);
            var oauth_token = qs["oauth_token"];
            var oauth_token_secret = qs["oauth_token_secret"];


            _userLogin = new UserLogin(oauth_token, oauth_token_secret);

            return _userLogin;
        }

        public UserLogin GetAccessToken()
        {

            var request = new RestRequest("oauth/access_token", Method.POST);
            _restClient.Authenticator = OAuth1Authenticator.ForAccessToken(_apiKey, _appsecret, _userLogin.Token, _userLogin.Secret);
            var response = _restClient.Execute(request);



            var qs = HttpUtility.ParseQueryString(response.Content);
            var oauth_token = qs["oauth_token"];
            var oauth_token_secret = qs["oauth_token_secret"];

            _userLogin = new UserLogin(oauth_token, oauth_token_secret);

            return _userLogin;
        }

        public AuthUser AccountInfo()
        {
            _restClient.BaseUrl = ApiBaseUrl;
            _restClient.Authenticator = AuthMethods();

            var request = new RestRequest("api/auth_user ", Method.GET);
            var response = _restClient.Execute<AuthUser>(request);

            _userLogin.Id = response.Data.User.Id;
            return response.Data;
        }

    }
}
