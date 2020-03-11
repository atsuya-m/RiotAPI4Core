using System.Collections.Generic;

namespace RiotAPI
{
    public class Champions
    {
        public string type { get; set; }
        public string format { get; set; }
        public string version { get; set; }
        public Dictionary<string, Champion> data { get; set; } = new Dictionary<string, Champion>();
    }

    public class Champion
    {
        public string version { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string blurb { get; set; }
        public Info info { get; set; }
        public Image image { get; set; }
        public string[] tags { get; set; }
        public string partype { get; set; }
        public Statss stats { get; set; }
    }

    public class Info
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int magic { get; set; }
        public int difficulty { get; set; }
    }

    public class Image
    {
        public string full { get; set; }
        public string sprite { get; set; }
        public string group { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
    }

    public class Statss
    {
        public float hp { get; set; }
        public float hpperlevel { get; set; }
        public float mp { get; set; }
        public float mpperlevel { get; set; }
        public float movespeed { get; set; }
        public float armor { get; set; }
        public float armorperlevel { get; set; }
        public float spellblock { get; set; }
        public float spellblockperlevel { get; set; }
        public float attackrange { get; set; }
        public float hpregen { get; set; }
        public float hpregenperlevel { get; set; }
        public float mpregen { get; set; }
        public float mpregenperlevel { get; set; }
        public float crit { get; set; }
        public float critperlevel { get; set; }
        public float attackdamage { get; set; }
        public float attackdamageperlevel { get; set; }
        public float attackspeedoffset { get; set; }
        public float attackspeedperlevel { get; set; }
    }
}