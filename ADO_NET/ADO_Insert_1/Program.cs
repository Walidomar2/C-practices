using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                    .AddJsonFile(@"D:\courses\c# .net core 8 with ms sql complete beginner to master\Udemy - C# .NET Core 8 with MS SQL Complete Beginner to Master 2023 2023-8\practices\ADO_NET\ADO_Insert_1\appsettings.json")
                    .Build();

            var connect = new SqlConnection(builder.GetSection("constr").Value);

            var newWallet = new Wallet{
                Holder = "Walid",
                Balance = 9600
            };
            

            string sqlCommand =@"INSERT INTO WALLETS (Holder, Balance) VALUES ('" + newWallet.Holder
                    + "','" + newWallet.Balance
                    + "')";

            var command = new SqlCommand(sqlCommand,connect);
            command.CommandType = CommandType.Text;

             connect.Open();

            if (command.ExecuteNonQuery() > 0)
            {
                Console.WriteLine($"wallet for {newWallet.Holder} added successully");
            }
            else
            {
                Console.WriteLine($"ERROR: wallet for {newWallet.Holder} was not added");
            }

            connect.Close();
        }
    }
}