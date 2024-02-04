using System;
using System.Runtime.InteropServices;

namespace App
{
    public class Employee
    {
        private const int _minLoggedHours = 176;
        private const decimal _overTimeRate = 1.25m;

        public string Name {get; set;}
        
        public int Id {get; set;}

        public int LoggedHours {get; set;}

        public decimal Wage {get; set;}

        public Employee(int id, string name, int loggedhours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedhours;
            Wage = wage;
        }

        private decimal CalculateBaseSalary()
        {
            var hours = Math.Min(_minLoggedHours , LoggedHours);
            return hours * Wage;
        }

        private decimal CalculateOvertimeSalary()
        {
            var overtime = ((LoggedHours - _minLoggedHours) > 0 ? (LoggedHours - _minLoggedHours) : 0 );
            return overtime * _overTimeRate;
        }

        public virtual decimal CalculateSalary()
        {
            return CalculateBaseSalary() + CalculateOvertimeSalary(); 
        }

        public override string ToString()
        {
            return $"ID: {Id}" +
                   $"\nName: {Name}"+
                   $"\nLogged Hours {LoggedHours} hrs"+
                   $"\nwage: {Wage}$"+
                   $"\nBase Salary: {Math.Round(CalculateBaseSalary(),2):N0}$"+
                   $"\nOverTime Salary: {Math.Round(CalculateOvertimeSalary(),2):N0}$";
        }

    }
}