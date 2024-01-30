using System;

namespace App
{
    public class Employee
    {
        private int _Id;
        private string _name;

        public Insurance EmployeeInsurance {get; set;}

        // must make the string member in Insurance class not null to be accessable so give it a default value
        public Employee() => EmployeeInsurance = new Insurance{PolicyId = -1, CompanyName = "N/A"};
        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public class Insurance
        {
            public int PolicyId;
            public string CompanyName;

        }
    }
}