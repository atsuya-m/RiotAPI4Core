using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace RiotAPI
{
    public partial class Client
    {
        public static List<string> getVersions()
        {
            return JsonSerializer.Deserialize<List<string>>(requestWithoutKEY("https://ddragon.leagueoflegends.com/api/versions.json"));
        }

        public static Champions getChampions(string patch)
        {
            return JsonSerializer.Deserialize<Champions>(requestWithoutKEY("http://ddragon.leagueoflegends.com/cdn/" + patch + "/data/en_US/champion.json"));
        }

        private static string requestWithoutKEY(string url)
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            using (var stream = response.GetResponseStream())
            {
                var sr = new System.IO.StreamReader(stream, System.Text.Encoding.GetEncoding("utf-8"));
                return sr.ReadToEnd();
            }
        }
    }
}
