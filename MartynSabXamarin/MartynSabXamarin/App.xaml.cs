using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MartynSabXamarin
{
    
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new ItemPage();
        }
        public static Page GetMainPage()
        {
            return new NavigationPage(new ItemPage());
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
