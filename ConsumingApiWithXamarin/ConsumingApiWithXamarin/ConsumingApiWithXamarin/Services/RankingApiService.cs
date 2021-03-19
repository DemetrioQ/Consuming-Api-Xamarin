using ConsumingApiWithXamarin.Helpers;
using ConsumingApiWithXamarin.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingApiWithXamarin.Services
{

    public class RankingApiService : IRankingApiService
    {
        public const string ApiKey = Secrets.ApiKey;
        ISerializerService serializerService = new SerializerService();

        public async Task<ObservableCollection<Ranking>> GetRankingAync(string queue, string tier, string division)
        {
            ObservableCollection<Ranking> ranking = null;
            var refitClient = RestService.For<IRankingApi>("https://na1.api.riotgames.com/lol/league-exp/v4/entries");

            var rankingResponse = await refitClient.GetRankingAync(queue, tier, division, ApiKey);

            if(rankingResponse.IsSuccessStatusCode)
            {
                var jsonRanking = await rankingResponse.Content.ReadAsStringAsync();
                ranking = serializerService.Deserialize<ObservableCollection<Ranking>>(jsonRanking);
            }
           

            return ranking;
        }
    }
}
