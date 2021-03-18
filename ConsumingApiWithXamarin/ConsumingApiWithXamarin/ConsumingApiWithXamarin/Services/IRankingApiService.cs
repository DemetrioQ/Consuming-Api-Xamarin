using ConsumingApiWithXamarin.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingApiWithXamarin.Services
{
    public interface IRankingApiService
    {
        [Get("/{queue}/{tier}/{division}?page=1&api_key={key}")]
        Task<Ranking> GetRanking(string queue, string tier, string division, string key);
    }
}
