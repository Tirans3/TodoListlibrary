using System;
using System.Collections;

namespace TodoList
{
    public class MyList<T>
    {

        Node<T> head;
        Node<T> tail;

        public int Count { get; set; }
        public bool IsEmpty { get { return Count == 0; } }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
                tail.Next = node;

            tail = node;
            Count++;
        }
        public T this[int i]
        {

            get
            {
                if (i > Count || i < 0)
                    throw new IndexOutOfRangeException("Input Correct index ");
                else
                {
                    Node<T> temp = head;
                    int t = 0;
                    do
                    {
                        if (i == t) return temp.Data;
                        temp = temp.Next;
                        t++;
                    } while (true);

                }

            }
            set
            {

                if (!(value is T))
                    throw new Exception("Input Correct oject ");
                else
                {


                    Node<T> temp = head;
                    int t = 0;
                    while (i != t)
                    {
                        temp = temp.Next;
                        t++;
                    }
                    temp.Data = value;
                }

            }
        }

        public MyList(int t)
        {


            for (int i = 0; i < t; i++)
            {

                Add(default(T));
            }
        }

        public MyList()
        {
        }

        public void Remove(T data)
        {
            if (!Contains(data)) return;
            Node<T> current = head;
            Node<T> prev = null;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (prev != null)
                    {
                        prev.Next = current.Next;

                        if (current.Next == null)
                            tail = prev;
                        Count--;
                        break;
                    }
                    else
                    {
                        head = head.Next;
                        Count--;
                        break;

                    }


                }
                prev = current;
                current = current.Next;


            }

        }


        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
        public bool Contains(T data)
        {

            Node<T> temp = head;

            while (temp != null)
            {
                if (temp.Data.Equals(data))
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data)
            {
                Next = head
            };
            head = node;
            if (Count == 0)
                tail = head;
            Count++;
        }
        public void Action(Func<T, bool> a)
        {
            foreach (T x in this)
            {
                if (a(x))
                {
                    Remove(x);
                }
            }
        }
        public void Show()
        {
            int i = 1;
            foreach (var c in this)
            {
                Console.WriteLine($"{i}" + c); i++;
            }

        }

        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i != Count)
                yield return this[i++];

        }
    }

}
