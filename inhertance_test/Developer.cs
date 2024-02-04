using System;

namespace App
{
    public class Developer : Employee
    {
        private const decimal Commission = 0.03m;
        
        protected bool TaskCompleted { get; set; }
        public Developer(int id, string name, int loggedHours, decimal wage,bool taskCompleted) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = taskCompleted;
        }

        private decimal CalculateBonus()
        {
            if (TaskCompleted)
                return base.CalculateSalary() * Commission;
            return 0;
        }

        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateBonus();
        }

         public override string ToString()
        {
            return base.ToString() +
                   $"\nTask Completed: ${(TaskCompleted ? "Yes" : "No")}" +
                   $"\nBonus: ${Math.Round(CalculateBonus(), 2):N0}" +
                   $"\nNet Salary: ${Math.Round(this.CalculateSalary(), 2):N0}";
        }

    }
}