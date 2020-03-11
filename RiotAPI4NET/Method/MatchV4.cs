using System.Collections.Generic;
using System.Text.Json;

namespace RiotAPI
{ 
    public class MatchDto
    {
        public int gameId { get; set; }
        public string platformId { get; set; }
        public long gameCreation { get; set; }
        public int gameDuration { get; set; }
        public int queueId { get; set; }
        public int mapId { get; set; }
        public int seasonId { get; set; }
        public string gameVersion { get; set; }
        public string gameMode { get; set; }
        public string gameType { get; set; }
        public Team[] teams { get; set; }
        public List<Participant> participants { get; set; }
        public Participantidentity[] participantIdentities { get; set; }

        public class Participant
        {
            public int participantId { get; set; }
            public int teamId { get; set; }
            public int championId { get; set; }
            public int spell1Id { get; set; }
            public int spell2Id { get; set; }
            public string highestAchievedSeasonTier { get; set; }
            public Stats stats { get; set; }
            public Timeline timeline { get; set; }
        }
    }

    public class Team
    {
        public int teamId { get; set; }
        public string win { get; set; }
        public bool firstBlood { get; set; }
        public bool firstTower { get; set; }
        public bool firstInhibitor { get; set; }
        public bool firstBaron { get; set; }
        public bool firstDragon { get; set; }
        public bool firstRiftHerald { get; set; }
        public int towerKills { get; set; }
        public int inhibitorKills { get; set; }
        public int baronKills { get; set; }
        public int dragonKills { get; set; }
        public int vilemawKills { get; set; }
        public int riftHeraldKills { get; set; }
        public int dominionVictoryScore { get; set; }
        public Ban[] bans { get; set; }
    }

    public class Ban
    {
        public int championId { get; set; }
        public int pickTurn { get; set; }
    }

    public class Stats
    {
        public int participantId { get; set; }
        public bool win { get; set; }
        public int item0 { get; set; }
        public int item1 { get; set; }
        public int item2 { get; set; }
        public int item3 { get; set; }
        public int item4 { get; set; }
        public int item5 { get; set; }
        public int item6 { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int assists { get; set; }
        public int largestKillingSpree { get; set; }
        public int largestMultiKill { get; set; }
        public int killingSprees { get; set; }
        public int longestTimeSpentLiving { get; set; }
        public int doubleKills { get; set; }
        public int tripleKills { get; set; }
        public int quadraKills { get; set; }
        public int pentaKills { get; set; }
        public int unrealKills { get; set; }
        public int totalDamageDealt { get; set; }
        public int magicDamageDealt { get; set; }
        public int physicalDamageDealt { get; set; }
        public int trueDamageDealt { get; set; }
        public int largestCriticalStrike { get; set; }
        public int totalDamageDealtToChampions { get; set; }
        public int magicDamageDealtToChampions { get; set; }
        public int physicalDamageDealtToChampions { get; set; }
        public int trueDamageDealtToChampions { get; set; }
        public int totalHeal { get; set; }
        public int totalUnitsHealed { get; set; }
        public int damageSelfMitigated { get; set; }
        public int damageDealtToObjectives { get; set; }
        public int damageDealtToTurrets { get; set; }
        public int visionScore { get; set; }
        public int timeCCingOthers { get; set; }
        public int totalDamageTaken { get; set; }
        public int magicalDamageTaken { get; set; }
        public int physicalDamageTaken { get; set; }
        public int trueDamageTaken { get; set; }
        public int goldEarned { get; set; }
        public int goldSpent { get; set; }
        public int turretKills { get; set; }
        public int inhibitorKills { get; set; }
        public int totalMinionsKilled { get; set; }
        public int neutralMinionsKilled { get; set; }
        public int neutralMinionsKilledTeamJungle { get; set; }
        public int neutralMinionsKilledEnemyJungle { get; set; }
        public int totalTimeCrowdControlDealt { get; set; }
        public int champLevel { get; set; }
        public int visionWardsBoughtInGame { get; set; }
        public int sightWardsBoughtInGame { get; set; }
        public int wardsPlaced { get; set; }
        public int wardsKilled { get; set; }
        public bool firstBloodKill { get; set; }
        public bool firstBloodAssist { get; set; }
        public bool firstTowerKill { get; set; }
        public bool firstTowerAssist { get; set; }
        public bool firstInhibitorKill { get; set; }
        public bool firstInhibitorAssist { get; set; }
        public int combatPlayerScore { get; set; }
        public int objectivePlayerScore { get; set; }
        public int totalPlayerScore { get; set; }
        public int totalScoreRank { get; set; }
        public int playerScore0 { get; set; }
        public int playerScore1 { get; set; }
        public int playerScore2 { get; set; }
        public int playerScore3 { get; set; }
        public int playerScore4 { get; set; }
        public int playerScore5 { get; set; }
        public int playerScore6 { get; set; }
        public int playerScore7 { get; set; }
        public int playerScore8 { get; set; }
        public int playerScore9 { get; set; }
        public int perk0 { get; set; }
        public int perk0Var1 { get; set; }
        public int perk0Var2 { get; set; }
        public int perk0Var3 { get; set; }
        public int perk1 { get; set; }
        public int perk1Var1 { get; set; }
        public int perk1Var2 { get; set; }
        public int perk1Var3 { get; set; }
        public int perk2 { get; set; }
        public int perk2Var1 { get; set; }
        public int perk2Var2 { get; set; }
        public int perk2Var3 { get; set; }
        public int perk3 { get; set; }
        public int perk3Var1 { get; set; }
        public int perk3Var2 { get; set; }
        public int perk3Var3 { get; set; }
        public int perk4 { get; set; }
        public int perk4Var1 { get; set; }
        public int perk4Var2 { get; set; }
        public int perk4Var3 { get; set; }
        public int perk5 { get; set; }
        public int perk5Var1 { get; set; }
        public int perk5Var2 { get; set; }
        public int perk5Var3 { get; set; }
        public int perkPrimaryStyle { get; set; }
        public int perkSubStyle { get; set; }
        public int statPerk0 { get; set; }
        public int statPerk1 { get; set; }
        public int statPerk2 { get; set; }
    }

    public class Timeline
    {
        public int participantId { get; set; }
        public Creepspermindeltas creepsPerMinDeltas { get; set; }
        public Xppermindeltas xpPerMinDeltas { get; set; }
        public Goldpermindeltas goldPerMinDeltas { get; set; }
        public Csdiffpermindeltas csDiffPerMinDeltas { get; set; }
        public Xpdiffpermindeltas xpDiffPerMinDeltas { get; set; }
        public Damagetakenpermindeltas damageTakenPerMinDeltas { get; set; }
        public Damagetakendiffpermindeltas damageTakenDiffPerMinDeltas { get; set; }
        public string role { get; set; }
        public string lane { get; set; }
    }

    public class Creepspermindeltas
    {
        public float _1020 { get; set; }
        public float _010 { get; set; }
    }

    public class Xppermindeltas
    {
        public float _1020 { get; set; }
        public float _010 { get; set; }
    }

    public class Goldpermindeltas
    {
        public float _1020 { get; set; }
        public float _010 { get; set; }
    }

    public class Csdiffpermindeltas
    {
        public float _1020 { get; set; }
        public float _010 { get; set; }
    }

    public class Xpdiffpermindeltas
    {
        public float _1020 { get; set; }
        public float _010 { get; set; }
    }

    public class Damagetakenpermindeltas
    {
        public float _1020 { get; set; }
        public float _010 { get; set; }
    }

    public class Damagetakendiffpermindeltas
    {
        public float _1020 { get; set; }
        public float _010 { get; set; }
    }

    public class Participantidentity
    {
        public int participantId { get; set; }
    }


    // matchlist
    public class MatchlistDto
    {
        public Match matches { get; set; }
        public int endIndex { get; set; }
        public int startIndex { get; set; }
        public int totalGames { get; set; }
    }

    public class Match
    {
        public string lane { get; set; }
        public int gameId { get; set; }
        public int champion { get; set; }
        public string platformId { get; set; }
        public long timestamp { get; set; }
        public int queue { get; set; }
        public string role { get; set; }
        public int season { get; set; }
    }


    // timeline
    public class MatchTimelineDto
    {
        public Frame[] frames { get; set; }
        public int frameInterval { get; set; }
    }

    public class Frame
    {
        public Dictionary<string, MatchParticipantFrameDto> participantFrames { get; set; } = new Dictionary<string, MatchParticipantFrameDto>();
        public _Event[] events { get; set; }
        public int timestamp { get; set; }
    }

    public class MatchParticipantFrameDto
    {
        public int participantId { get; set; }
        public Position position { get; set; }
        public int currentGold { get; set; }
        public int totalGold { get; set; }
        public int level { get; set; }
        public int xp { get; set; }
        public int minionsKilled { get; set; }
        public int jungleMinionsKilled { get; set; }
        public int dominionScore { get; set; }
        public int teamScore { get; set; }
    }

    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class _Event
    {
        public string type { get; set; }
        public int timestamp { get; set; }
        public int participantId { get; set; }
        public int itemId { get; set; }
        public int skillSlot { get; set; }
        public string levelUpType { get; set; }
        public string wardType { get; set; }
        public int creatorId { get; set; }
        public Position position { get; set; }
        public int killerId { get; set; }
        public int victimId { get; set; }
        public int[] assistingParticipantIds { get; set; }
        public int afterId { get; set; }
        public int beforeId { get; set; }
        public string monsterType { get; set; }
        public string monsterSubType { get; set; }
        public int teamId { get; set; }
        public string buildingType { get; set; }
        public string laneType { get; set; }
        public string towerType { get; set; }
    }


    public partial class Client
    {
        public MatchDto GetMatches(long matchId)
        {
            var url = "/lol/match/v4/matches/";
            return JsonSerializer.Deserialize<MatchDto>(request(url + matchId));
        }

        public MatchlistDto GetMatchlistsByAccountID(string encryptedAccountId)
        {
            var url = "/lol/match/v4/matchlists/by-account/";
            return JsonSerializer.Deserialize<MatchlistDto>(request(url + encryptedAccountId));
        }

        public MatchTimelineDto GetTimelinesByMatch(long matchId)
        {
            var url = "/lol/match/v4/timelines/by-match/";
            return JsonSerializer.Deserialize<MatchTimelineDto>(request(url + matchId));
        }
    }
}