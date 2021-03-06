using ConsumingApiWithXamarin.Services;
using ConsumingApiWithXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsumingApiWithXamarin.Views
{
    public partial class RankingPage : ContentPage
    {
        public RankingPage()
        {
            InitializeComponent();
            BindingContext = new RankingViewModel(new RankingApiService(), new AlertService());
        }
    }
}
