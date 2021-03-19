using ConsumingApiWithXamarin.Models;
using ConsumingApiWithXamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ConsumingApiWithXamarin.ViewModels
{
    public class RankingViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Ranking> Ranking { get; set; }
        public RankingInfo rankingInfo { get; set; }
        IRankingApiService _rankingApiService { get; }
        public bool IsBusy { get; set; }
        ICommand GetCommand { get; }
        public bool IsNotBusy => !IsBusy;

        public RankingViewModel(IRankingApiService rankingApiService)
        {
            _rankingApiService = rankingApiService;
            rankingInfo = new RankingInfo();
            GetCommand = new Command<RankingInfo>(LoadRanking);
        }

        public async void LoadRanking(RankingInfo info)
        {
            IsBusy = true;
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                Ranking = await _rankingApiService.GetRankingAync(info.Queue, info.Tier, info.Division);
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
