using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace DateApp{

    public class Date
    {
        private static readonly int[] DaysToMonths365 = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        private static readonly int[] DaysToMonths366 = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}; 
        private ushort _day;
        private ushort _month;
        private uint _year;
        
         private void valuesValidation(ushort dayValue, ushort monthValue, uint yearValue)
      {
        var isLeap = ((yearValue % 4 == 0) && ((yearValue % 100 != 0) || (yearValue % 400 == 0)));
            if(yearValue >= 1 && yearValue<=9999 && monthValue>=1 && monthValue<=12)
            {
                int[] Days = isLeap ? DaysToMonths366 : DaysToMonths365;
                if(dayValue >= 1 && dayValue <= Days[monthValue])
                {
                    _day = dayValue;
                    _month = monthValue;
                    _year = yearValue;
                }
                else
                {
                    Console.WriteLine("Please Enter a valid numbers you are in a default date now........");
                    _day = 01;
                    _month = 01;
                    _year = 0001;
                }
            }
            else
            {
                Console.WriteLine("you are in a default date now.");
                _day = 01;
                _month = 01;
                _year = 0001;
            }
      }


        public Date(): this(01,01,0001)
        {
        }

        public Date(ushort day, ushort month, uint year)
        {
           // Console.Write($"{day}   {month}    {year}");
           valuesValidation(day,month,year);
        }


        public uint Year
        {
            get
            {
                return _year;

            }
            set
            {
                if(value >= 1 && value <= 9999)
                    _year = value;
                else
                   Console.WriteLine("Please Enter a Valid year value"); 
            }
        }

        public ushort Month
        {
            get
            {
                return _month;
            }
            set
            {   
                if(value >= 1 && value <= 12)
                    _month = value;
                else
                    Console.WriteLine("Please Enter a Valid month value");
            }
        }

        public ushort Day
        {
            get
            {
                return _day;
            }
            set
            {
                valuesValidation(value,_month,_year);
            }
        }

          public string getDate()
        {
            return $"the date: {Day.ToString().PadLeft(2,'0')} / {Month.ToString().PadLeft(2,'0')} / {Year.ToString().PadLeft(4,'0')}";
        }
    }
}