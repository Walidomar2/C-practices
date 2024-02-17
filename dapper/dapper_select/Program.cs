using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                        .AddJsonFile(@"D:\courses\c# .net core 8 with ms sql complete beginner to master\Udemy - C# .NET Core 8 with MS SQL Complete Beginner to Master 2023 2023-8\practices\dapper\dapper_select\appsettings.json")
                        .Build();

            IDbConnection db = new SqlConnection(config.GetSection("constr").Value);

            string sqlCommand = "SELECT * FROM Wallets";

            var list = db.Query<Wallet>(sqlCommand);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

}