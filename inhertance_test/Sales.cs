using System;

namespace App
{
    public class Sales : Employee
    {
        protected decimal SalesVolume { get; set; }
        protected decimal Commission { get; set; }

         public Sales(int id, string name, int loggedHours, decimal wage, decimal salesvol, decimal commission) : base(id, name, loggedHours, wage)
        {
            SalesVolume = salesvol;
            Commission = commission;
        }

        private decimal CalculateBonus()
        {
            return Commission * SalesVolume;
        }

        public override decimal CalculateSalary()
        {
            return CalculateBonus() + base.CalculateSalary();
        }

        public override string ToString()
        {
            return base.ToString() + 
                   $"\nCommission Rate: {Math.Round(Commission,2):N0}$"+
                   $"\nSales Volume: {Math.Round(SalesVolume,2):N0}$"+
                   $"\nBonus: {Math.Round(CalculateBonus(),2):N0}$"+
                   $"\nNet Salary: {Math.Round(CalculateSalary(),2):N0}$";
        }         

    }
}