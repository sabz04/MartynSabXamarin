using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MartynSabXamarin.Models
{
    public class Database
    {
        static string folder = System
            .Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        public static bool CreateDatabase()
        {
            try {
                using(var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.CreateTable<Article>();
                    Console.WriteLine("Create database is successfull");
                    return true;
                }
            
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool InsertToArticle(Article article)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    if (connection.Table<Article>().ToList().Any(x => x.Title == article.Title))
                    {
                        DeleteToArticle(article);
                        return false;
                    }
                       
                    connection.Insert(article);
                    Console.WriteLine($"Insert {article.Title} is success");
                    return true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool DeleteToArticle(Article article)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    connection.Delete(article);
                    Console.WriteLine($"Delete {article.Title} is success");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static List<Article> SelectArticles()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "Persons.db")))
                {
                    
                    Console.WriteLine("Select is successfull");
                    return connection.Table<Article>().ToList();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
