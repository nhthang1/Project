using QLCT.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace QLCT
{
    public partial class App : Application
    {
        public static WalletManager walletManager { get; set; } 
        public static ExchangeManager ExchangeManager {get; set;}
        public static PayChartManager PayChartManager { get; set; }
        public App()
        {
            InitializeComponent();
            walletManager = new WalletManager(new RestService());
            ExchangeManager = new ExchangeManager(new ExchangeRestservice());
            PayChartManager = new PayChartManager(new PayChartService());
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
