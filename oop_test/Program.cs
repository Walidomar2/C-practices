using System;
using System.Runtime.Intrinsics.Arm;
namespace app{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emps = new Employee[2];
            emps[0] = new Employee();
            emps[1] = new Employee();

            Console.WriteLine("First Employee");

            Console.Write("Enter the First Name: ");
            emps[0].fName = Console.ReadLine();

            Console.Write("Enter the Last Name: ");
            emps[0].lName = Console.ReadLine();

            Console.Write("Enter the Wages: ");
            emps[0].Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Logged Hours: ");
            emps[0].loggedHours = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");
            
            Console.WriteLine("Second Employee");

            Console.Write("Enter the First Name: ");
            emps[1].fName = Console.ReadLine();

            Console.Write("Enter the Last Name: ");
            emps[1].lName = Console.ReadLine();

            Console.Write("Enter the Wages: ");
            emps[1].Wage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Logged Hours: ");
            emps[1].loggedHours = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------------------");

            displayEmployeeInfo(emps);

        }

       static void displayEmployeeInfo(Employee[] emps)
        {
            double netSalary = 0 ;
            foreach(var emp in emps)
            {
                netSalary = (emp.loggedHours * emp.Wage) - (emp.loggedHours * emp.Wage * Employee.TAX);
                Console.WriteLine("First Name: "+emp.fName);
                Console.WriteLine("Last Name: " +emp.lName);
                Console.WriteLine("Wage: " + emp.Wage);
                Console.WriteLine("Logged Hours: " + emp.loggedHours);
                Console.WriteLine("Employee's net salary: " + netSalary);
                Console.WriteLine("-----------------------------------------");
            }

        }
     
    }
}

