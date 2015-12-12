using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    class Stack<T>
    {
        private T[] elements;
        private int capacity = 10;
        private T topElement;
        private int counter = 0;

        public int Capacity
        {
            get
            {
                return capacity;
            }

            set
            {
                capacity = value;
            }
        }

        public T TopElement
        {
            get
            {
                return topElement;
            }

            set
            {
                topElement = value;
            }
        }

        public T[] Elements
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

        public int Counter
        {
            get
            {
                return counter;
            }

            set
            {
                counter = value;
            }
        }

        //Constructor
        public Stack(int capacity)              
        {
            this.capacity = capacity;
            this.elements = new T[capacity];
        }

        //Find the object at the top of the stack without delting it
        public T Peek()                       
        {
            topElement = elements[counter - 1];
            return topElement;
        }

        //Remove the top of stack and returns it 
        public T Pop()                      
        {
            
            T top = Peek();
            elements[counter] = default(T);
            counter--;

            if (counter < capacity/2)
            {
                Resize(false);
            }

            return top;
        }

        //Insert an object at the top of the stack
        public void Push(T item)
        { 
            
            elements[counter] = item;

            counter++;

            if (counter >= capacity/2)
            {
                Resize(true);
            }
        }

        //Remove all objects from the stack
        public void Clear()
        {
            for (int i = elements.Length - 1; i >= 0; i--)
            {
                elements[i] = default(T);

            }
        }

        //Determines whether an element is in the stack
        public bool Contains(T item)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        private void Resize(bool increase)
        {
            if (increase)
            {
                if(capacity <= counter)
                {
                    capacity *= 2;
                }

                T[] newElements = new T[capacity];
                for (int i = 0; i < elements.Length; i++)
                {
                    newElements[i] = elements[i];
                }
            }

            else
            {
                capacity /= 2;

                T[] newElements = new T[capacity];
                for (int i = 0; i < newElements.Length; i++)
                {
                    newElements[i] = elements[i];
                }
            }
        }
    }
}
