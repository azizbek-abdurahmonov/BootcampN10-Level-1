using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT1
{
    internal class CustomList<T>
    {
        private readonly int _capacity = 0;
        private T[] _items;

        public CustomList()
        {
            _items = new T[_capacity];
        }

        public CustomList(int _size)
        {
            if (_size < 0)
            {
                throw new Exception("array length cannot be less than 0");
            }
            else
            {
                _items = new T[_capacity];
            }
        }

        // Custom list methods
        public void Add(T item)
        {
            CheckSize();
            _items[_items.Length - 1] = item;
        }

        public void AddRange(params T[] items)
        {
            foreach (var item in items)
                Add(item);
        }

        public bool Contains(T item)
        {
            foreach (var itemB in _items)
                if (itemB.Equals(item)) return true;

            return false;
        }


        public void CopyTo(T[] array)
        {
            if (array.Length < _items.Length)
                throw new Exception("length of array is less than length of list");


            for (var index = 0; index < _items.Length; index++)
            {
                array[index] = _items[index];
            }
        }

        public int IndexOf(T item)
        {
            for (var index = 0; index < _items.Length; index++)
            {
                if (_items[index].Equals(item))
                    return index;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            var newArray = new T[_items.Length + 1];

            for (var i = 0; i < index; i++)
                newArray[i] = _items[i];

            newArray[index] = item;

            for (var idx = index + 1; idx < newArray.Length; idx++)
            {
                newArray[idx] = _items[idx - 1];
            }


            _items = newArray;
        }

        public void InsertRange(int index, params T[] items)
        {
            foreach (var item in items)
            {
                Insert(index, item);
                index++;
            }
        }

        public bool Remove(T item)
        {
            try
            {

                var newArray = new T[_items.Length - 1];

                bool isNotFound = true;
                var index = 0;
                for (var idx = 0; idx < _items.Length; idx++)
                {
                    if (_items[idx].Equals(item) && isNotFound)
                    {
                        isNotFound = false;
                    }
                    else
                    {
                        newArray[index] = _items[idx];
                        index++;
                    }
                }

                if (isNotFound)
                    return false;
                else
                {
                    _items = newArray;
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= _items.Length)
                return false;

            var newArray = new T[_items.Length - 1];

            bool isNotFound = true;
            var indexB = 0;
            for (var idx = 0; idx < _items.Length; idx++)
            {
                if (idx == index && isNotFound)
                {
                    isNotFound = false;
                }
                else
                {
                    newArray[indexB] = _items[idx];
                    indexB++;
                }
            }

            if (isNotFound)
                return false;
            else
            {
                _items = newArray;
                return true;
            }



        }

        public T[] ToArray()
        {
            return _items;
        }

        public void CheckSize()
        {
            Array.Resize(ref _items, _items.Length + 1);

        }

        public override string ToString()
        {
            var Items = string.Empty;
            foreach (var item in _items)
                Items += item + " ";
            return Items;
        }
    }
}

