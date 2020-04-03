using System;
using RiotAPI;
using System.Text.Json;
namespace APITestCS
{
    class Program
    {
        static void Main(string[] args)
        {
            RiotAPI.Client riotAPI = new RiotAPI.Client("RGAPI-e24e5a1c-08a3-46d5-af2f-31e73225a054");
            Console.WriteLine(JsonSerializer.Serialize(riotAPI.GetActiveGamesBySummoner("uZDrouGjkSiM6OcX6BNPWCq--3l8LaQIzUP6YMjQ02lamA")));
        }
    }
}