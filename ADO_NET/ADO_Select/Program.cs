using System;
using System.Data;
using EF02.ExecuteRawSql;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                    .AddJsonFile(@"D:\courses\c# .net core 8 with ms sql complete beginner to master\Udemy - C# .NET Core 8 with MS SQL Complete Beginner to Master 2023 2023-8\practices\ADO_NET\ADO_Select\appsettings.json")
                    .Build();

            var connect = new SqlConnection(builder.GetSection("constr").Value);

            string sqlCommand  = "SELECT * FROM WALLETS";

            var command = new SqlCommand(sqlCommand,connect);
            command.CommandType = CommandType.Text;

            connect.Open();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                var Wallet = new Wallet{
                    Id = reader.GetInt32("Id"),
                    Holder = reader.GetString("Holder"),
                    Balance = reader.GetDecimal("Balance")
                };

                Console.WriteLine(Wallet);
            }
        }
    }
}