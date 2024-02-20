using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace App
{
    public class EFCore_Functions
    {
        public void EFCore_RetriveData()
        {

            using (var context = new Appdbcontext())
            {
                foreach (var wallet in context.Wallets)
                {
                    Console.WriteLine(wallet);
                }

            }
        }

        public void EFCore_OneItem(int id)
        {

            using (var context = new Appdbcontext())
            {
               var wallet = context.Wallets.FirstOrDefault(x => x.Id == id);

               Console.WriteLine(wallet);
            }
        }

        public void EFCore_InsertData(Wallet wallet)
        {
            using (var context = new Appdbcontext())
            {
                context.Wallets.Add(wallet);
                context.SaveChanges();  
            }
        }

        public void EFCore_UpdateDate(int id,decimal balance = 0)
        {
            if (balance < 0)
                throw new ArgumentException("Balance Can't be less than 0.");

            using (var context = new Appdbcontext())
            {
                var wallet = context.Wallets.Single(x => x.Id == id);

                wallet.Balance = balance;
                context.SaveChanges();
            }
        }

        public void EFCore_UpdateDate(int id, string name = "")
        {

            using (var context = new Appdbcontext())
            {
                var wallet = context.Wallets.Single(x => x.Id == id);
                wallet.Holder = name;
                context.SaveChanges();
            }
        }

        public void EFCore_UpdateDate(int id,string name="",decimal balance=0)
        {

            if (balance < 0)
                throw new ArgumentException("Balance Can't be less than 0.");

            if (name == "")

                throw new ArgumentException("Name Can't be Empty.");

            using (var context = new Appdbcontext())
                {
                    var wallet = context.Wallets.Single(x => x.Id == id);

                    wallet.Balance = balance;
                    wallet.Holder = name;

                    context.SaveChanges();  
                }

        }

        public void EFCore_DeleteData(int id)
        {
            using (var context = new Appdbcontext())
            {
                var wallet = context.Wallets.Single( x => x.Id == id);
                context.Wallets.Remove(wallet); 

                context.SaveChanges();
            }
        }
    }
}
