using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Lesson_9._2_2023_05_17
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string path = @"Data Source = test.db;";
            var connection = new SQLiteConnection(path);
            connection.Open();
            Console.WriteLine($"Подключено " + $"{connection.ToString()}");
            string query = @"CREATE TABLE IF NOT EXISTS Person(id INTEGER PRIMARY KEY AUTOINCREMENT"
            connection.Close();
            Console.ReadKey();
        }
    }
}
