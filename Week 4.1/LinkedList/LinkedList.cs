using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
        where T : class
    {
        class Node
        {
            private T value;
            private Node next;

            public T Value
            {
                get
                {
                    return value;
                }

                set
                {
                    this.value = value;
                }
            }

            public Node Next
            {
                get
                {
                    return next;
                }

                set
                {
                    next = value;
                }
            }

            public Node(T value)
            {
                this.value = value;
                this.next = null;
            }
        }

        private Node head;
        private Node current;
        private int count;
 
        private Node Head
        {
            get
            {
                return head;
            }

            set
            {
                head = value;
            }
        }

        public int Count
        {
            get
            {
                Node node = head;
                while (node != null)
                {
                    count++;
                    node = node.Next;
                }
                return count;
            }

            set
            {
                count = value;
            }
        }

        public T this[int index]
        {
            get
            {
                Node node = head;
                int counter = 0;
                while (node != null)
                {
                    if (counter == index)
                    {
                        Console.WriteLine(node.Value);
                        return node.Value;
                    }
                    node = node.Next;
                    counter++;
                }

                return node.Value;
            }

            set
            {
                Node node = head;
                int counter = 0;
                while (node != null)
                {
                    if (counter == index)
                    {
                        node.Value = value;
                        break;
                    }
                    node = node.Next;
                    counter++;
                }
            }
        }

        public LinkedList()
        {
            head = null;
            current = head;

        } 

        public void Add(T value)
        {
            Node node = head;

            if (node == null)
            {
                head = new Node(value);
                return;
            }

            while (node.Next != null)
            {
                node = node.Next;
            }

            Node addedNode = new Node(value);
            node.Next = addedNode;
        }

        public void InsertAfter(T key, T value)
        {
            Node node = head;

            while (node != null && !node.Value.Equals(key))
            {
                node = node.Next;
            }

            Node addedNode = new Node(value);
            addedNode.Next = node.Next;
            node.Next = addedNode;
        }

        public void InsertBefore(T key, T value)
        {
            Node prev = null;
            Node currNode = head;

            while (currNode != null && !currNode.Value.Equals(key))
            {
                prev = currNode;
                currNode = currNode.Next;
            }
            if (currNode != null)
            {
                Node addedNode = new Node(value);
                prev.Next = addedNode;
                addedNode.Next = currNode;
            }
        }

        public void InsertAt(int index, T value)
        {
            Node node = head;
            int counter = 0;
            if (index == 0)
            {
                head = new Node(value);
                head.Next = node;
                return;
            }
            while (node.Next != null)
            {
                counter++;
                node = node.Next;

                if (counter == index - 1)
                {
                    Node addedNode = new Node(value);
                    addedNode.Next = node.Next;
                    node.Next = addedNode;
                    break;
                }

                else if (index > counter)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public void Remove(T value)
        {
            Node node = head;
            Node nextNode = null;
            while (!node.Value.Equals(value))
            {
                nextNode = node;
                node = node.Next;

                if (node == null)
                {
                    return;
                }
            }

            nextNode.Next = node.Next;
            node = null;
        }

        public void RemoveAt(int index)
        {
            Node node = head;
            Node prevNode = null;
            int counter = 0;

            while (node.Next != null)
            {
                counter++;
                prevNode = node;
                node = node.Next;

                if (counter == index)
                {
                    prevNode.Next = node.Next;
                    node = null;
                    break;
                }
            }
        }

        public void Clear()
        {
            Node temp = head;
            while (head != null)
            {
                temp = head.Next;
                temp = null;

            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node node = head;
            while (node!=null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node node = head;
            while (node != null)
            {
                yield return node;
                node = node.Next;
            }
        }

        public T Current
        {
            get
            {
                return current != null ? current.Value :(T) null;
            }
        }
    }
}
