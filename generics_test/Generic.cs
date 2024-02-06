using System;

namespace App
{

    class Any<T>
    {
        private T[] _items;

        public bool IsEmpty => _items is null || _items.Length == 0 ;

        public int Count => _items.Length;

        public void Add(T item)
        {
            if(_items is null || _items.Length == 0)
            {
                _items = new T[]{item};
            }
            else
            {
                var length = _items.Length;

                var dest = new T[length + 1];

                for(int i=0;i<_items.Length;i++)
                {
                    dest[i] = _items[i];
                }

                dest[length] = item;

                _items = dest;
            }
        }

        public void Remove(int position)
        {
            
            if(_items.Length == 0 || position < 0 || position > _items.Length)
                return;
            else
            {
                position --;
                
                var index = 0;
                var length = _items.Length ;
                var dest = new T[length - 1];

                for(int i=0;i<_items.Length;i++)
                {
                    if(i == position)
                        continue;
                    
                    dest[index++] = _items[i];
                }

                _items = dest;
            }
        }

        public void DisplayItems()
        {
            Console.Write("[");
            for(int i=0;i<_items.Length;i++)
            {
                Console.Write(_items[i]);
                if(i != _items.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }

    }
}