using System;
using System.Text.Json;

namespace RiotAPI
{
    public class SummonerDTO
    {
        public int profileIconId { get; set; }
        public string name { get; set; }
        public string puuid { get; set; }
        public int summonerLevel { get; set; }
        public string accountId { get; set; }
        public string id { get; set; }
        public long rivisionDate { get; set; }
    }

    public partial class Client
    {
        public SummonerDTO GetSummonersByName(string summonerName)
        {
            var url = "/lol/summoner/v4/summoners/by-name/";
            string param = Uri.EscapeUriString(summonerName);

            return JsonSerializer.Deserialize<SummonerDTO>(request(url + param));
        }

        public SummonerDTO GetSummoners(string encryptedSummonerId)
        {
            var url = "/lol/summoner/v4/summoners/";
            return JsonSerializer.Deserialize<SummonerDTO>(request(url + encryptedSummonerId));
        }

        public SummonerDTO GetSummonersByAccount(string encryptedAccountId)
        {
            var url = "/lol/summoner/v4/summoners/by-account/";
            return JsonSerializer.Deserialize<SummonerDTO>(request(url + encryptedAccountId));
        }

        public SummonerDTO GetSummonersByPUUID(string encryptedPUUID)
        {
            var url = "/lol/summoner/v4/summoners/by-puuid/";
            return JsonSerializer.Deserialize<SummonerDTO>(request(url + encryptedPUUID));
        }
    }
}
