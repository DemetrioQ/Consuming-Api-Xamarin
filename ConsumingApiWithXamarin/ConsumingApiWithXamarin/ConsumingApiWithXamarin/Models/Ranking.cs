using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsumingApiWithXamarin.Models
{
    public class Ranking
    {

        [JsonPropertyName("summonerName")]
        public string SummonerName { get; set; }

        [JsonPropertyName("leaguePoints")]
        public int LeaguePoints { get; set; }

        [JsonPropertyName("wins")]
        public int Wins { get; set; }

        [JsonPropertyName("losses")]
        public int Losses { get; set; }

    }

}
