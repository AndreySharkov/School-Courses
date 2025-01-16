using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Implementation_of_a_List
{
    public class CustomArrayList
    {
        private object[] arr;
        private int count;
        public int Count
        {
            get { return count; }
            private set { count = value; }
        }
        private static readonly int INITIAL_CAPACITY = 4;

        public CustomArrayList()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }

        private void Resize()
        {
            object[] copy = new object[arr.Length * 2]; 
            Array.Copy(arr, copy, arr.Length);
            arr = copy;
        }

        public void Add(object item)
        {
            Insert(count, item);
        }

        public void Insert(int index, object item)
        {
            if (count >= arr.Length)
            {
                Resize();
            }

            for (int i = count; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[index] = item;
            count++;
        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < count; i++)
            {
                if (arr[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Clear()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }

        public bool Contains(object item)
        {
            return IndexOf(item) != -1;
        }
             

        public object Remove(int index)
        {
            if(index >= Count ||  index < 0)
            {
                throw new ArgumentOutOfRangeException($"Invalid index: {index}");
            }

            object removedItem = arr[index];

            for (int i = index; i < count - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[count - 1] = null;
            count--;

            if (count <= arr.Length / 4)
            {
                Shrink();
            }

            return removedItem;
        }

        public int Remove(object item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                Remove(index);
            }
            return index;
        }

        private void Shrink()
        {
            object[] newArr = new object[arr.Length / 2];
            for (int i = 0; i < count; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }
    }

}
