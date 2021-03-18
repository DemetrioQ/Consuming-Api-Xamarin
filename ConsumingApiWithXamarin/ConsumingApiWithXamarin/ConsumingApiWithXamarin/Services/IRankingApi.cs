using ConsumingApiWithXamarin.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsumingApiWithXamarin.Services
{
    public interface IRankingApi
    {
        [Get("/RANKED_SOLO_5x5/CHALLENGER/I?page=1&api_key={key}")]
        Task<ObservableCollection<Ranking>> GetRankingAync(string key);
    }
}
