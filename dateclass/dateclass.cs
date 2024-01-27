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
        
        public Date(): this(01,01,0001)
        {
        }

        public Date(ushort day, ushort month, uint year)
        {
            var isLeap = ((_year % 4 == 0) && ((_year % 100 != 0) || (_year % 400 == 0)));

            if(year >= 1 && year<=9999 && month>=1 && month<=12)
            {
                int[] Days = isLeap ? DaysToMonths366 : DaysToMonths365;

                if(day>= 1 && day <= Days[month])
                {
                    _day = day;
                    _month = month;
                    _year = year;
                }
                else
                {
                    Console.WriteLine("Please Enter a valid numbers you are in a default date now.");
                    _day = 01;
                    _month = 01;
                    _year = 0001;
                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid numbers you are in a default date now.");
                _day = 01;
                _month = 01;
                _year = 0001;
            }
        }

         public string getDate()
        {
            return $"the date: {_day.ToString().PadLeft(2,'0')} / {_month.ToString().PadLeft(2,'0')} / {_year.ToString().PadLeft(4,'0')}";
        }

        public void setDay(ushort day)
        {
            _day = day;
        }

        public ushort getDay()
        {
            return _day;
        }

        public void setMonth(ushort month)
        {
            _month = month;
        }

        public ushort getMonth()
        {
            return _month;
        }

        public void setYear(uint year)
        {
            _year = year;
        }

        public uint getYear()
        {
            return _year;
        }
    }
}