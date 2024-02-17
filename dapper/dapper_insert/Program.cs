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
                        .AddJsonFile(@"D:\courses\c# .net core 8 with ms sql complete beginner to master\Udemy - C# .NET Core 8 with MS SQL Complete Beginner to Master 2023 2023-8\practices\dapper\dapper_insert\appsettings.json")
                        .Build();

            IDbConnection db = new SqlConnection(config.GetSection("constr").Value);

            var newWallet = new Wallet {
                Holder = "Omar",
                Balance = 9600
            };

            string sqlCommand = "INSERT INTO Wallets (Holder , Balance) VALUES (@Holder, @Balance)";

            var parameters = new {
                Holder = newWallet.Holder,
                Balance = newWallet.Balance
            };

            var rows = db.Execute(sqlCommand, parameters);

            if(rows!=0)
            {
                Console.WriteLine($"{rows} Rows affected");
            }
            else
            {
                Console.WriteLine("Something Wrong");
            }
        }
    }

}