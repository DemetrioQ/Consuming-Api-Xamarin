using ConsumingApiWithXamarin.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ConsumingApiWithXamarin.Services
{
    public interface IRankingApiService
    {
        Task<ObservableCollection<Ranking>> GetRankingAync(string queue, string tier, string division);
    }
}