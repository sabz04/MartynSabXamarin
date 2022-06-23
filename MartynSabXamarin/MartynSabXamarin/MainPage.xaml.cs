using MartynSabXamarin.Models;
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
            var articles = Database.SelectArticles(); 
            if(articles.Any(x=>x.Url == url))
            {
                likLb.Text = "Сохранено";
            }
            var tapWrp = new TapGestureRecognizer();
            tapWrp.Tapped += (s, e) =>
            {
                if (!ItemPage.page.likeFlag)
                {
                    ItemPage.page.LoadArticles(Database.SelectArticles());
                }
                if (ItemPage.page.likeFlag)
                {
                    ItemPage.page.LoadArticles();
                }
                Navigation.PopModalAsync();
            };
            backPanel.GestureRecognizers.Add(tapWrp);
            actionBrowser.Source = url;

            var likeTap = new TapGestureRecognizer();
            likeTap.Tapped += (sender, e) =>
            {
                var currentArticle = Article.articles.FirstOrDefault(x => x.Url == url);
                
                if (Database.InsertToArticle(currentArticle))
                {
                    likLb.Text = "Сохранено";
                }
                else
                {
                    likLb.Text = "В избранное";
                }
            };
            likePanel.GestureRecognizers.Add(likeTap);
        }
    }
}
