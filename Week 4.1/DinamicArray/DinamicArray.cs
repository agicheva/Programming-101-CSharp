using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicArray
{
    public class DinamicArray<T>
    {
        private T[] dinamicArr;
        private int capacity;       //the size of the array
        private int count;          //the number of elements in the array

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return dinamicArr[index];
            }

            set
            {
                if (index < 0 || index >= count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                dinamicArr[index] = value;
            }
        }


        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public DinamicArray()
        {
            count = 0;
            capacity = 10;
            dinamicArr = new T[capacity];
        }

        public DinamicArray(int capacity)
        {
            this.capacity = capacity;
            dinamicArr = new T[capacity];
            count = 0;
        }

        //Check if an element is in the array
        public bool Contains(T value)
        {
            for (int i = 0; i < dinamicArr.Length; i++)
            {
                if (dinamicArr[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        //Returns the index of element with given value
        public int IndexOf(T value)
        {
            int count = 0;
            bool isFound = true;

            for (int i = 0; i < dinamicArr.Length; i++)
            {
                if (dinamicArr[i].Equals(value) && isFound)
                {
                    isFound = false;
                    return count;
                }
                count++;
            }
            return -1;
        }

        //Add element with given value at the end of the array
        public void Add(T value)
        {
            if (count == capacity)
            {
                Resize(true);
            }

            dinamicArr[count++] = value;
        }

        //Resize the array
        public void Resize(bool increase)
        {
            if (increase)
            {
                if (capacity < 2048)
                {
                    if (capacity == 0)
                    {
                        capacity = 1;
                    }
                    else
                    {
                        capacity *= 2;
                    }
                }

                else
                {
                    capacity += 256;
                }
            }

            else
            {
                capacity /= 2;
            }

            T[] newDinamicArr = new T[capacity];

            for (int i = 0; i < count; i++)
            {
                newDinamicArr[i] = dinamicArr[i];
            }
            dinamicArr = newDinamicArr;
        }

        //Insert a new element at a given index
        public void InsertAt(int index, T value)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == count)
            {
                Add(value);
            }

            for (int i = count - 1; i >= 0; i--)
            {
                dinamicArr[i + 1] = dinamicArr[i];
                if (index == i)
                {
                    dinamicArr[i] = value;
                    break;
                }
            }
            count++;
        }

        //Deletes the first occurence of the specified element
        public void Remove(T value) 
        {
            int index = IndexOf(value);
            RemoveAt(index);
            
        }

        //Deletes the element at given index
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == count - 1)
            {
                count--;
                if (count == capacity/3)
                {
                    Resize(false);
                }
            }


            for (int j = index; j < count - 1; j++)
            {
                dinamicArr[j] = dinamicArr[j + 1];
            }

            count--;
            if (count == capacity / 3)
            {
                Resize(false);
            }

        }

        //Deletes all elements
        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                RemoveAt(i);
            }
        }

        //Copy elements in simple array
        public T[] ToArray()
        {
            T[] array = new T[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = dinamicArr[i];
            }

            return array;
        }
    }
}
