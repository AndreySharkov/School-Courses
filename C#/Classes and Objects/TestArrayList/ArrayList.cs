using System;
using System.Collections.Generic;
using System.Text;

namespace BasicArrayList
{
    public class ArrayList
    {
        private const int Initial_Capacity = 2;
        private int[] items;

        public ArrayList()
        {
            this.items = new int[Initial_Capacity];
        }

        public int Count { get; private set; }

        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                int[] copy = new int[this.items.Length * 2];
                for (int i = 0; i < this.items.Length; i++)
                {
                    copy[i] = this.items[i];
                }
                this.items = copy;
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public int CountFreePositions()
        {
            return this.items.Length - this.Count;
        }

        public void Cut(int count)
        {
            if (count > this.Count || count < 0)
            {
                throw new ArgumentOutOfRangeException("Number is out of range.");
            }

            int[] newItems = new int[count];
            for (int i = 0; i < count; i++)
            {
                newItems[i] = this.items[i];
            }

            this.items = newItems;
            this.Count -= count;
        }



        public int Change(int element, int newElement)
        {
            
            
        }

    }
}
