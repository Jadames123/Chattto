using Chattto.MapperService;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chattto
{
    public partial class App : Application
    {
        public App()
        {
            MapperSetting.Initialization();

            InitializeComponent();

            MainPage = new NavigationPage(new LoguinPage());
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
