using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinamicArray;

namespace Map
{
    public class Map<T, U>
    {
        DinamicArray<T> keys;
        DinamicArray<U> values;

        public DinamicArray<T> Keys
        {
            get
            {
                return keys;
            }

            set
            {
                keys = value;
            }
        }

        public DinamicArray<U> Values
        {
            get
            {
                return values;
            }

            set
            {
                values = value;
            }
        }

        public int Count
        {
            get
            {
                return keys.Count;
            }
        }

        public U this[T key]
        {
            get
            {
                int index = keys.IndexOf(key);
                if (!keys.Contains(key))
                {
                    throw new ArgumentException();
                }

                return values[index];
            }

            set
            {
                if (!keys.Contains(key))
                {
                    Add(key, value);
                }
                values[keys.IndexOf(key)] = value;
            }
        }

        public Map()
        {
            keys = new DinamicArray<T>();
            values = new DinamicArray<U>();
        }

        public Map(DinamicArray<T> keys, DinamicArray<U> values)
        {
            this.keys = keys;
            this.values = values;
        }

        public void Add(T key, U value)
        {
            if (keys.Contains(key))
            {
                throw new ArgumentException();
            }
            keys.Add(key);
            values.Add(value);
        }

        public bool ContainsKey(T key)
        {
            if (keys.Contains(key))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool ContainsValue(U value)
        {
            if (values.Contains(value))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Remove(T key)
        {
            int index = keys.IndexOf(key);
            keys.RemoveAt(index);
            values.RemoveAt(index);
        }

        public void Clear()
        {
            keys.Clear();
            values.Clear();
        }
    }
}
