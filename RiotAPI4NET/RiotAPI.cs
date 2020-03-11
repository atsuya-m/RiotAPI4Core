using System;
using System.Net;
using System.IO;
using System.Reflection;

namespace RiotAPI
{
    public partial class Client
    {
        private string key;
        private string endPoint = "https://jp1.api.riotgames.com";
        public Client(string key) {
            this.key = key;
        }
        public Client(string key, string region)
        {
            this.key = key;
            this.endPoint = region;
        }
        private string request(string url)
        {
            WebRequest request = WebRequest.Create(endPoint + url);
            request.Headers.Add("X-Riot-Token", this.key);
            WebResponse response = request.GetResponse();
            using (var stream = response.GetResponseStream())
            {
                var sr = new System.IO.StreamReader(stream, System.Text.Encoding.GetEncoding("utf-8"));
                return sr.ReadToEnd();
            }
        }
    }
}
