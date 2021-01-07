using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YoutubeApiApp
{
    public partial class App : Application
    {
        public static bool videostart = false;
        public static string videourl;
        public static WebView videoView;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
