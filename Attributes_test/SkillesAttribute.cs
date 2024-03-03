using System;
using System.Collections.Generic;


namespace App
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SkillesAttribute : Attribute
    {
        public SkillesAttribute(string name, int minValue, int maxValue)
        {
            Name = name;
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public string Name { get; private set; }
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }

        public bool IsValid(object obj)
        { 
            return (int) obj >= MinValue && (int) obj <= MaxValue;
        }
    }
}
