using System;

namespace App
{
    public class Maintenance : Employee
    {
        private const decimal _hardshipRate = 100m;

        public Maintenance(int id, string name, int loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
        }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + _hardshipRate;
        }

        public override string ToString()
        {
            return base.ToString()+
                   $"\nHardship : {Math.Round(_hardshipRate,2):N0}$"+
                   $"\nNet Salary: {Math.Round(CalculateSalary(),2):N0}$";  
        }
    }
}