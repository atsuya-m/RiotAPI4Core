using System.Collections.Generic;
using System.Text.Json;

namespace RiotAPI
{

    public class CurrentGameInfo
    {
        public int gameId { get; set; }
        public int mapId { get; set; }
        public string gameMode { get; set; }
        public string gameType { get; set; }
        public int gameQueueConfigId { get; set; }
        public List<Participant> participants { get; set; }
        public Observers observers { get; set; }
        public string platformId { get; set; }
        public List<Bannedchampion> bannedChampions { get; set; }
        public long gameStartTime { get; set; }
        public int gameLength { get; set; }

        public class Participant
        {
            public int teamId { get; set; }
            public int spell1Id { get; set; }
            public int spell2Id { get; set; }
            public int championId { get; set; }
            public int profileIconId { get; set; }
            public string summonerName { get; set; }
            public bool bot { get; set; }
            public string summonerId { get; set; }
            public object[] gameCustomizationObjects { get; set; }
            public Perks perks { get; set; }
        }
    }

    public class Observers
    {
        public string encryptionKey { get; set; }
    }

    public class Perks
    {
        public int[] perkIds { get; set; }
        public int perkStyle { get; set; }
        public int perkSubStyle { get; set; }
    }

    public class Bannedchampion
    {
        public int championId { get; set; }
        public int teamId { get; set; }
        public int pickTurn { get; set; }
    }


    // featured games
    public class FeaturedGames
    {
        public int clientRefreshInterval { get; set; }
        public Gamelist[] gameList { get; set; }
    }

    public class Gamelist
    {
        public int gameId { get; set; }
        public long gameStartTime { get; set; }
        public string platformId { get; set; }
        public string gameMode { get; set; }
        public int mapId { get; set; }
        public string gameType { get; set; }
        public int gameQueueConfigId { get; set; }
        public Observers observers { get; set; }
        public Participant[] participants { get; set; }
        public int gameLength { get; set; }
        public Bannedchampion[] bannedChampions { get; set; }
    }

    public class Participant
    {
        public int profileIconId { get; set; }
        public int championId { get; set; }
        public string summonerName { get; set; }
        public bool bot { get; set; }
        public int spell2Id { get; set; }
        public int teamId { get; set; }
        public int spell1Id { get; set; }
    }

    public partial class Client
    {
        public CurrentGameInfo GetActiveGamesBySummoner(string encryptedSummonerId)
        {
            var url = "/lol/spectator/v4/active-games/by-summoner/";
            return JsonSerializer.Deserialize<CurrentGameInfo>(request(url + encryptedSummonerId));
        }

        public FeaturedGames GetFeaturedGames()
        {
            var url = "/lol/spectator/v4/featured-games";
            return JsonSerializer.Deserialize<FeaturedGames>(request(url));
        }
    }
}
