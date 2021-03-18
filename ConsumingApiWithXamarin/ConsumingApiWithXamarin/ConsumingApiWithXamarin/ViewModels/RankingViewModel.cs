using ConsumingApiWithXamarin.Models;
using ConsumingApiWithXamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Essentials;

namespace ConsumingApiWithXamarin.ViewModels
{
    public class RankingViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Ranking> Ranking { get; set; }
         IRankingApiService _rankingApiService { get; }
        public bool IsBusy { get; set; }

        public bool IsNotBusy => !IsBusy;

        public RankingViewModel(IRankingApiService rankingApiService)
        {
            _rankingApiService = rankingApiService;
            LoadRanking();
        }

        public async void LoadRanking()
        {
            IsBusy = true;
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                Ranking = await _rankingApiService.GetRankingAync();
                
            }
            else
            {
                //Show alert
            }

            IsBusy = false;
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
