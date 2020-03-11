using System.Collections.Generic;

namespace RiotAPI
{

    public class ChampionInfo
    {
        public List<int> freeChampionIds { get; set; }
        public List<int> freeChampionIdsForNewPlayers { get; set; }
        public int maxNewPlayerLevel { get; set; }
    }

    public partial class Client
    {
        public ChampionInfo GetChampionRotations()
        {
            var url = "/lol/platform/v3/champion-rotations";
            return System.Text.Json.JsonSerializer.Deserialize<ChampionInfo>(request(url));
        }
    }
}
