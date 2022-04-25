using System;
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

        public void SortForQueue(int[] items)//bu sıralama algoritmasını seçtim verimsiz ama bunun algoritmasını iyi kavramıştım
        {
            int tarama;
            bool swapped=false;
            for (tarama = 0; tarama < items.Length; tarama++)
            {

                swapped = false;
              
                
                for(int i=0;i<(items.Length-tarama-1);i++)
                {
                    if (items[i] > items[i + 1])
                    {
                        int temp;
                        temp= items[i];
                        items[i]=items[i+1];
                        items[i+1]=temp;
                        swapped=true;

                    }


                }

                if (!swapped) break;

            }
        }

      

        int IQueue.BinarySearchForQueue(int[] items, int searchkey)
        {
            int baslangic = 0, bitis = items.GetUpperBound(0), orta = baslangic + bitis / 2;
            while (baslangic <= bitis)
            {
                orta = (baslangic + bitis) / 2;

                if (items[orta] > searchkey) bitis = orta - 1;
                else if (items[orta] < searchkey) baslangic = orta + 1;
                else return orta;

            }

            return -1;
        }
    }
}
