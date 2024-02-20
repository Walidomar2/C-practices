using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    class Progam
    {
        static void Main()
        {
            var EFcore = new EFCore_Functions();

            Console.WriteLine("--------------- Showing DB Data ---------------------");
            EFcore.EFCore_RetriveData();
            Console.WriteLine("\n--------------- Showing DB single Item --------------");
            EFcore.EFCore_OneItem(1);


            Console.WriteLine("\n--------------- Inserting Data ----------------------");
            var wallet_1 = new Wallet()
            {
                Holder = "Walid",
                Balance = 11000,
            };
            
            EFcore.EFCore_InsertData(wallet_1);
            EFcore.EFCore_RetriveData();


            Console.WriteLine("\n--------------- Updating Data ----------------------");
            EFcore.EFCore_UpdateDate(1, "Omar", 5000);
            EFcore.EFCore_UpdateDate(2,7000);
            EFcore.EFCore_RetriveData();

            Console.WriteLine("\n--------------- Deleting Data ----------------------");

            EFcore.EFCore_DeleteData(3);
            EFcore.EFCore_RetriveData();


            Console.ReadKey();
        }
    }
}