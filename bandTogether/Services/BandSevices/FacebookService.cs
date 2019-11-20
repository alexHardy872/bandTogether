using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using bandTogether.Models;
using bandTogether.Models.ViewModels;

namespace bandTogether.Services.Band
{
    public static class FacebookService
    {


        public static async Task<List<string>> GetPermaUrlFromPost(string bandId )
        {
            //string PostId = "1308735289192501_2556755371057147";
            
            string requestUri = string.Format("https://graph.facebook.com/{0}/posts?fields=permalink_url&access_token={1}", bandId, Private.Secrets.facebookAccessToken);
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            dynamic stuff = await Task.Run(() => JObject.Parse(content));
            var data = stuff["data"];
            

            List<string> permaLinks = new List<string>();

            foreach (var post in data)
            {
                //if (post.id == PostId)
                //{
                //    permalink_url = post.permalink_url;
                //    break;
                //}
                string perm = post.permalink_url;

                permaLinks.Add(perm);
            }
            return  permaLinks;
        }

       


   






    }
}