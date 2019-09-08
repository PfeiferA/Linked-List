using System;
using System.Collections;

namespace LinkedList.Model
{
    /// <summary>
    /// singly linked list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>:IEnumerable
    {
        /// <summary>
        /// first lists item
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// last lists item
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// items amount in list
        /// </summary>
        public int Count { get; private set; }
        public LinkedList()
        {
            Clear();
        }
        /// <summary>
        ///create a list with an initial element
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(data);
        }
        /// <summary>
        /// add data to the end of the list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            if(Tail!=null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        /// <summary>
        /// delete the first occurrence of data in the list
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if (Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if(current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
        }
        /// <summary>
        /// append date in head
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
        }
        public void InsertAfter(T target,T data)
        {
            if (Head != null)
            {
                var item = new Item<T>(data);
                var current = Head;
                while(current!=null)
                {
                    if (current.Data.Equals(target))
                    {
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
            else
            {

            }
        }
        /// <summary>
        /// Clear list
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        /// <summary>
        /// get an listing of all list items
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current!=null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        public override string ToString()
        {
            return "Linked List "+Count+" items";
        }
    }
}
