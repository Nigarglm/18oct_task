using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_18oct
{
    internal class ListInt
    {
        private int[] arr;
        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
        
        public ListInt()
        {
            arr = new int[0];
        }

        public ListInt(int length)
        {
            arr = new int[length];
        }

        public void Add(int num)
        {
            Array.Resize(ref arr, arr.Length +1);
            arr[arr.Length-1] = num;
        }
        public void AddRange(params int[] nums)
        {
            foreach(int num in nums)
            {
                Add(num);
            }
        }

        public bool Contains(int num)
        {
            foreach (int item in arr)
            {
                if (item == num)
                {
                    return true;
                }
            }
            return false;
        }

        public int Sum()
        {
            int sum = 0;
            foreach(int num in arr)
            {
                sum+= num;  
            }
            return sum;
        }

        public void Remove(int num)
        {
            if (arr.Length == 0) return;

            int index = Array.IndexOf(arr, num);
            if (index != -1)
            {
                for (int i = index; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                Array.Resize(ref arr, arr.Length - 1);
            }
        }

        public void RemoveRange(params int[] nums)
        {
            foreach(int num in nums)
            {
                Remove(num);
            }
        }

        public override string ToString()
        {
            if (arr.Length == 0)
                return "[]";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[");
            for (int i = 0; i < arr.Length; i++)
            {
                stringBuilder.Append(arr[i] + ",");
            }
            stringBuilder.Append(arr[arr.Length-1]+"]");
            return stringBuilder.ToString();
        }

    }
}
