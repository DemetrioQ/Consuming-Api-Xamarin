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
        IAlertService _alertService { get; }
        public bool IsBusy { get; set; }
        public ICommand GetCommand { get; }
        public bool IsNotBusy => !IsBusy;

        public RankingViewModel(IRankingApiService rankingApiService, IAlertService alertService)
        {
            _rankingApiService = rankingApiService;
            _alertService = alertService;
            rankingInfo = new RankingInfo();
            GetCommand = new Command<RankingInfo>(LoadRanking);
        }

        public async void LoadRanking(RankingInfo info)
        {
            IsBusy = true;
            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                if(info.Tier == "CHALLENGER")
                {
                    info.Division = "I";
                }
                Ranking = await _rankingApiService.GetRankingAync(info.Queue, info.Tier, info.Division);
            }
            else
            {
                await _alertService.DisplayAlertAsync("No internet connection", "No internet connection detected");
            }

            IsBusy = false;
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }
}
