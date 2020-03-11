using System.Collections.Generic;
using System.Text.Json;

namespace RiotAPI
{
    public class ChampionMasteryDTO
    {
        public int championLevel { get; set; }
        public bool chestGranted { get; set; }
        public int championPoints { get; set; }
        public int championPointsSinceLastLevel { get; set; }
        public int championPointsUntilNextLevel { get; set; }
        public string summonerId { get; set; }
        public int tokensEarned { get; set; }
        public int championId { get; set; }
        public long lastPlayTime { get; set; }
    }


    public partial class Client
    {
        public List<ChampionMasteryDTO> GetChampionMasteryBySummoner(string encryptedSummonerId)
        {
            var url = "/lol/champion-mastery/v4/champion-masteries/by-summoner/";
            return JsonSerializer.Deserialize<List<ChampionMasteryDTO>>(request(url + encryptedSummonerId));
        }

        public ChampionMasteryDTO GetChampionMasteryBySummonerAndChampionId(string encryptedSummonerId, int championId)
        {
            var url = "/lol/champion-mastery/v4/champion-masteries/by-summoner/" + encryptedSummonerId + "/by-champion/" + championId.ToString();
            return JsonSerializer.Deserialize<ChampionMasteryDTO>(request(url));
        }

        public int GetScoresBySummoner(string encryptedSummonerId)
        {
            var url = "/lol/champion-mastery/v4/scores/by-summoner/" + encryptedSummonerId;
            return int.Parse(request(url));
        }
    }
}
