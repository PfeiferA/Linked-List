﻿using LinkedList.Model;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ring Linked List
            var circularList = new CirkularLinkedList<int>();
            circularList.Add(1);
            circularList.Add(2);
            circularList.Add(3);
            circularList.Add(4);
            circularList.Add(5);

            foreach(var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            circularList.Delete(3);

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion
            #region Duplex List
            var duplexList = new DuplexLinkedList<int>();
            duplexList.Add(1);
            duplexList.Add(2);
            duplexList.Add(3);
            duplexList.Add(4);
            duplexList.Add(5);

             foreach(var item in duplexList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            duplexList.Delete(3);

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var reverse= duplexList.Reverse();

            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            #endregion
            #region Linked List
            var list = new Model.LinkedList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach(var item in list)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.AppendHead(7);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.InsertAfter(7, 9);
            list.InsertAfter(4, 8);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            #endregion
            Console.ReadKey();
        }
    }
}
