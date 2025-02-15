﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
     public class LinkedList
    {
        private Node head;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }
        public Object Add(int index, Object o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("Index : " + index);
            if (index > count)
                index = count;
            Node current = this.head;
            if(this.Empty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for(int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(o, current.Next);
            }
            count++;
            return o;
        }
        public Object Add(Object o)
        {
            return this.Add(count, o);
        }
        public bool Empty
        {
            get { return this.count==0; }
        }

        public int Count
        {

        get { return this.count; }
        }

        public Object Remove(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index : " + index);
            }
            if (this.Empty)
                return null;
            if (index >= this.count)
                index = count - 1;
            Node current = this.head;
            Object result = null;
            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for(int i = 0; i < index - 1; i++)
                    current = current.Next;

                result = current.Next.Data;
            }
            count--;
            return result;
        }
        public void Clear()
        {
            this.head = null;
        }
       
        public int IndexOf(Object o)
        {
            Node current = this.head;

            for(int i = 0; i < this.count; i++)
            {
                if (current.Data.Equals(o))
                    return i;
                current = current.Next;
            }
            return -1;
        }

        public bool Contains(Object o)
        {
            return this.IndexOf(o) >= 0;
        }
        public void Show()
        {
            Node current = this.head;
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

}
