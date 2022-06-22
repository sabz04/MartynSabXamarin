using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MartynSabXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(string url)
        {
            InitializeComponent();
            var tapWrp = new TapGestureRecognizer();
            tapWrp.Tapped += (s, e) =>
            {
                Navigation.PushModalAsync(new ItemPage(
                    ));
            };
            backPanel.GestureRecognizers.Add(tapWrp);
            actionBrowser.Source = url;
        }
    }
}
