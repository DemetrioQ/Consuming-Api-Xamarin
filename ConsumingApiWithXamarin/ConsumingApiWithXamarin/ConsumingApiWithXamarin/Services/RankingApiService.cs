using ConsumingApiWithXamarin.Helpers;
using ConsumingApiWithXamarin.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingApiWithXamarin.Services
{
    public class RankingApiService : IRankingApiService
    {
        public const string ApiKey = Secrets.ApiKey;
        public Task<Ranking> GetRanking(string queue, string tier, string division, string key)
        {
            throw new NotImplementedException();
        }
    }
}
