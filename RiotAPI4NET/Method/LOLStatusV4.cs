using System;
using System.Collections.Generic;

namespace RiotAPI
{
    public class ShardStatus
    {
        public string name { get; set; }
        public string region_tag { get; set; }
        public string hostname { get; set; }
        public List<Service> services { get; set; }
        public string slug { get; set; }
        public List<string> locales { get; set; }
    }

    public class Service
    {
        public string status { get; set; }
        public List<Incident> incidents { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
    }

    public class Incident
    {
        public bool active { get; set; }
        public DateTime created_at { get; set; }
        public int id { get; set; }
        public List<Update> updates { get; set; }
    }

    public class Update
    {
        public string severity { get; set; }
        public string author { get; set; }
        public DateTime created_at { get; set; }
        public List<object> translations { get; set; }
        public DateTime updated_at { get; set; }
        public string content { get; set; }
        public string id { get; set; }
    }


    public partial class Client
    {
        public ShardStatus GetShardData()
        {
            var url = "/lol/status/v3/shard-data";
            return System.Text.Json.JsonSerializer.Deserialize<ShardStatus>(request(url));
        }
    }

}