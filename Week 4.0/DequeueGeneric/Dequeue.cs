using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DequeueGeneric
{
    class Dequeue<T>
    {
        private List<T> elements;
        private T top;
        private T low;

        public List<T> Elements
        {
            get
            {
                return elements;
            }

            set
            {
                elements = value;
            }
        }

        public T Top
        {
            get
            {
                return top;
            }

            set
            {
                top = value;
            }
        }

        public T Low
        {
            get
            {
                return low;
            }

            set
            {
                low = value;
            }
        }

        //Constructor
        public Dequeue()
        {
            elements = new List<T>();
        }

        //Remove all objects
        public void Clear()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                elements.RemoveAt(i);
            }
        }

        //Determines whether an element is in the Dequeue
        public bool Contains(T item)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        //Returns the element at the beginning of the Dequeue
        public T PeekFromFront()
        {
            low = elements[0];
            return low;
        }

        //Returns the element at the end of the Dequeue
        public T PeekFromEnd()
        {
            top = elements[elements.Count - 1];
            return top;
        }

        //Remove and return the element at the beginning of the Dequeue
        public T RemoveFromFront()
        {
            T low = PeekFromFront();
            elements.Remove(low);
            return low;
        }

        //Remove and return the element at the end of the Dequeue
        public T RemoveFromEnd()
        {
            T top = PeekFromEnd();
            elements.Remove(top);
            return top;
        }

        //Insert an element at the beginning of the Dequeue
        public void AddToFront(T item)
        {
            elements.Insert(0, item);
        }

        //Insert an element at the end of the Dequeue
        public void AddToEnd(T item)
        {
            elements.Add(item);
        }


    }
}
