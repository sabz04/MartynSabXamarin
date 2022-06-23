using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MartynSabXamarin.Models
{
    public class Article
    {
        public static List<Article> articles = new List<Article>();
        [PrimaryKey]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get;set; }
        
    }
}
