﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    public class Queue : IQueue
    {

        public  object[] Queue;

        private int front = -1;
        private int back = -1;
        private int size = 0;
        public int count = 0;
        public Queue(int size)
        {
            this.size = size;
            Queue = new object[size];

        }
        public int Count()
        {
            return count;
        }

        public void Insert(object item)
        {
            if ((count == size) || (back == size))
            {
                throw new Exception("Queue Dolu");
            }
            if (front == -1)
            {
                front = 0;
            }
            Queue[++back] = item;
            count++;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public object Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Kuyruk boş");
            }
            object temp = Queue[front];
            Queue[front] = null;
            count--;
            front++;

            return temp;
        }
    }
}
