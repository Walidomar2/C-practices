using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee();
            Console.WriteLine(emp.EmployeeInsurance.CompanyName);

            emp.EmployeeInsurance.CompanyName = "walid";

            Console.WriteLine(emp.EmployeeInsurance.CompanyName);

        }
    }
}


