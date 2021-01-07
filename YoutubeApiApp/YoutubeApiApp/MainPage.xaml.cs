using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using YoutubeApiApp.Model;
using YoutubeApiApp.ViewModel;

namespace YoutubeApiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new YoutubeViewModel();
        }

        private async void generallistview_FlowItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
            {
                return;
            }
            var current = Connectivity.NetworkAccess;
            if (current != NetworkAccess.Internet)
            {
                await DisplayAlert("No Internet Connection", "You are currently not connected to the internet." +
                                   " You need to have an active connection to watch this video.", "OK");
                return;
            }

            var youtubeItem = e.Item as VideoItem;
            var videoId = youtubeItem.VideoId;

            await Navigation.PushAsync(new SingleView(videoId)
            {
                BindingContext = youtubeItem
            });

        }
    }
}
