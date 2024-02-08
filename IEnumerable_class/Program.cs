using System;
using System.Collections;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new FiveIntegers(1, 2, 3, 4, 5);

            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
        }
    }

    class FiveIntegers : IEnumerable
    {
        private int[] _value;

        public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
        {
            _value = new int[] { n1, n2, n3, n4, n5 };

        }

        public IEnumerator GetEnumerator() => new Enumerator(this);

        class Enumerator : IEnumerator
        {
            int currentIndex = -1;
            FiveIntegers _integers;

            public Enumerator(FiveIntegers integers)
            {
                _integers = integers;
            }

            public object Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new InvalidOperationException("Enumeration not started");
                    if (currentIndex == _integers._value.Length)
                        throw new InvalidOperationException("Enumeration Ended");
                    return _integers._value[currentIndex];
                }
            }
            public bool MoveNext()
            {
                if (currentIndex >= _integers._value.Length - 1)
                    return false;
                return ++currentIndex < _integers._value.Length;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

        }
    }
}
