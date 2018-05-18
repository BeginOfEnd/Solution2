using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_BL
{
    public class Queue<T> : IEnumerable<T>
    {
        public Node<T> head { get; set; } // головной/первый элемент
        public Node<T> tail { get; set; } // последний/хвостовой элемент
       
        public int Count { get; set; }
        public bool IsEmpty { get { return Count == 0; } }
        // добавление в очередь
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (Count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            Count++;
        }
        // удаление из очереди
        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            Count--;
            return output;
        }
        // получаем первый элемент
        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }
        // получаем последний элемент
        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }        

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public string Print(Queue<T> queue)
        {
            string text = "";
            foreach (T items in queue)
            {
                text += Convert.ToString(items);
                text += "\r\n";
            }
            return text;
        }
        

        public Queue<T> Sort(Queue<T> queue)
        {
            List<T> list = new List<T>();
            list = queue.ToList<T>();
            list.Sort();
            List<T> LIST = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                queue.Dequeue();
            }
            for (int i = 0; i < list.Count; i++)
            {
                queue.Enqueue(list[i]);
            }
            return queue;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
    }
