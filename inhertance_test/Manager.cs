using System;

namespace App
{
    public class Manager : Employee
    {
        private const decimal _allowanceRate = 0.05m;

        public Manager(int id, string name, int loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
        }

        private decimal CalculateAllowance()
        {
            return _allowanceRate * base.CalculateSalary();
        }

        public override decimal CalculateSalary()
        {
            return CalculateAllowance() + base.CalculateSalary();
        }

        public override string ToString()
        {
            return base.ToString()+
                   $"\nAllowance : {Math.Round(CalculateAllowance(),2):N0}$"+
                   $"\nNet Salary: {Math.Round(CalculateSalary(),2):N0}$";  
        }
    }
}