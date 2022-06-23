using MartynSabXamarin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MartynSabXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPage : ContentPage
    {
        public static ItemPage page;
        Style lbStyle = (Style)Application.Current.Resources["lbStyle"];
        Style lbStyle2 = (Style)Application.Current.Resources["lbStyle2"];
        Style imgStyle = (Style)Application.Current.Resources["imgStyle"];
        public bool likeFlag = true;
        public ItemPage()
        {
            InitializeComponent();
            
            curentUserInfoLB.Text = $"Справочник по C#";
            LoadArticles();
            var tapImg = new TapGestureRecognizer();
            page = this;
            tapImg.Tapped += (s, e) => {
                if (likeFlag)
                {
                    var articles = Database.SelectArticles();
                    actionsPanel.Children.Clear();
                    LoadArticles(articles);
                    likeFlag = false;
                    return;

                }
                if (!likeFlag)
                {
                    actionsPanel.Children.Clear();
                    LoadArticles();
                    likeFlag = true;
                    return;
                }


            };
            likedPanel.GestureRecognizers.Add(tapImg);
        }
        
        public ItemPage(string currentUser)
        {
            InitializeComponent();
            curentUserInfoLB.Text = $"Справочник по C#";
            LoadArticles();
            
        }

        public void LoadArticles()
        {
            actionsPanel.Children.Clear();
            Article.articles = new List<Article>
            {
                new Article
                {
                   Id =0,
                   Title="Глава 1. Введение в C#",
                   Url="https://metanit.com/sharp/tutorial/1.1.php",
                },
                new Article
                {
                   Id =1,
                   Title="Глава 2. Основы программирования на C#",
                   Url="https://metanit.com/sharp/tutorial/1.5.php",
                },
                new Article
                {
                   Id =2,
                   Title="Глава 3. Классы, структуры и пространства имен",
                   Url="https://metanit.com/sharp/tutorial/3.1.php",
                },
                new Article
                {
                   Id =3,
                   Title="Глава 4. Объектно-ориентированное программирование",
                   Url="https://metanit.com/sharp/tutorial/3.7.php",
                },
                new Article
                {
                   Id =4,
                   Title="Глава 5. Обработка исключений",
                   Url="https://metanit.com/sharp/tutorial/2.14.php",
                },
                new Article
                {
                   Id =5,
                   Title="Глава 6. Делегаты, события и лямбды",
                   Url="https://metanit.com/sharp/tutorial/3.13.php",
                },
                new Article
                {
                   Id =6,
                   Title="Глава 7. Интерфейсы",
                   Url="https://metanit.com/sharp/tutorial/3.9.php",
                },
                new Article
                {
                   Id =7,
                   Title="Глава 8. Дополнительные возможности ООП в C#",
                   Url="https://metanit.com/sharp/tutorial/3.36.php",
                },
                new Article
                {
                   Id =8,
                   Title="Глава 9. Pattern matching",
                   Url="https://metanit.com/sharp/tutorial/3.34.php",
                },
                new Article
                {
                   Id =9,
                   Title="Глава 10. Коллекции",
                   Url="https://metanit.com/sharp/tutorial/4.5.php",
                },
                new Article
                {
                   Id =10,
                   Title="Глава 11. Работа со строками",
                   Url="https://metanit.com/sharp/tutorial/7.1.php",
                },
                new Article
                {
                   Id =11,
                   Title="Глава 12. Работа с датами и временем",
                   Url="https://metanit.com/sharp/tutorial/19.1.php",
                },
                new Article
                {
                   Id =12,
                   Title="Глава 13. Дополнительные классы и структуры .NET",
                   Url="https://metanit.com/sharp/tutorial/20.1.php",
                },
                new Article
                {
                   Id =13,
                   Title="Глава 14. Многопоточность",
                   Url="https://metanit.com/sharp/tutorial/11.1.php",
                },
                new Article
                {
                   Id =14,
                   Title="Глава 15. Параллельное программирование и библиотека TPL",
                   Url="https://metanit.com/sharp/tutorial/12.1.php",
                },
                new Article
                {
                   Id =15,
                   Title="Глава 16. Aсинхронное программирование. Task-based Asynchronous Pattern",
                   Url="https://metanit.com/sharp/tutorial/13.3.php",
                },
                new Article
                {
                   Id =16,
                   Title="Глава 17. LINQ",
                   Url="https://metanit.com/sharp/tutorial/15.1.php",
                },
                new Article
                {
                   Id =17,
                   Title="Глава 18. Parallel LINQ",
                   Url="https://metanit.com/sharp/tutorial/17.1.php",
                },
                new Article
                {
                   Id =18,
                   Title="Глава 19. Рефлексия",
                   Url="https://metanit.com/sharp/tutorial/14.1.php",
                },
                 new Article
                {
                   Id =19,
                   Title="Глава 20. Dynamic Language Runtime",
                   Url="https://metanit.com/sharp/tutorial/9.1.php",
                },
                  new Article
                {
                   Id =20,
                   Title="Глава 21. Сборка мусора, управление памятью и указатели",
                   Url="https://metanit.com/sharp/tutorial/8.1.php",
                },
                   new Article
                {
                   Id =21,
                   Title="Глава 22. Работа с файловой системой",
                   Url="https://metanit.com/sharp/tutorial/5.1.php",
                },
                    new Article
                {
                   Id =22,
                   Title="Глава 23. Работа с JSON",
                   Url="https://metanit.com/sharp/tutorial/6.5.php",
                },
                     new Article
                {
                   Id =23,
                   Title="Глава 24. Работа с XML в C#",
                   Url="https://metanit.com/sharp/tutorial/16.1.php",
                },
                     new Article
                {
                   Id =24,
                   Title="Глава 25. Процессы и домены приложения",
                   Url="https://metanit.com/sharp/tutorial/18.1.php",
                },
                     new Article
                {
                   Id =25,
                   Title="Глава 26. Валидация модели",
                   Url="https://metanit.com/sharp/tutorial/22.1.php",
                },
                     new Article
                {
                   Id =26,
                   Title="Глава 27. Что нового",
                   Url="https://metanit.com/sharp/tutorial/23.1.php",
                },

            };
            foreach (var action in Article.articles)
            {
                StackLayout wrpPanel = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    VerticalOptions = LayoutOptions.Center,
                };
                var tapWrp = new TapGestureRecognizer();
                tapWrp.Tapped += (s, e) =>
                {
                    
                    Navigation.PushModalAsync(new MainPage(
                        action.Url
                        ));
                };
                wrpPanel.GestureRecognizers.Add(tapWrp);
                wrpPanel.Children.Add(new Label
                {
                    Style = lbStyle2,
                    Margin = new Thickness(10, 5, 0, 5),
                    Text = action.Title
                });
                wrpPanel.Children.Add(new Image
                {
                    Style = imgStyle,
                });
                actionsPanel.Children.Add(wrpPanel);
            }

        }
        public void LoadArticles(List<Article> articles)
        {
            actionsPanel.Children.Clear();
            foreach (var action in articles)
            {
                StackLayout wrpPanel = new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    VerticalOptions = LayoutOptions.Center,
                };
                var tapWrp = new TapGestureRecognizer();
                tapWrp.Tapped += (s, e) =>
                {

                    Navigation.PushModalAsync(new MainPage(
                        action.Url
                        ));
                };
                wrpPanel.GestureRecognizers.Add(tapWrp);
                wrpPanel.Children.Add(new Label
                {
                    Style = lbStyle2,
                    Margin = new Thickness(10, 5, 0, 5),
                    Text = action.Title
                });
                wrpPanel.Children.Add(new Image
                {
                    Style = imgStyle,
                });
                actionsPanel.Children.Add(wrpPanel);
            }

        }
    }
}