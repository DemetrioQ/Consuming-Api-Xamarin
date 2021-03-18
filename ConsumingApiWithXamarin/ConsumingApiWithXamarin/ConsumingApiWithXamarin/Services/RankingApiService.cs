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
        public async Task<ObservableCollection<Ranking>> GetRankingAync()
        {
            ObservableCollection<Ranking> ranking = null;
            var refitClient = RestService.For<IRankingApi>("https://na1.api.riotgames.com/lol/league-exp/v4/entries");
            ranking = await refitClient.GetRankingAync(ApiKey);

            return ranking;
        }
    }
}
