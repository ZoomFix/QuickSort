using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Program
    {
        public static int i;

        static void Main(string[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            int[] A = { 1, 3, 5, 2, 9, 8, 6, 4, 7, 0, 23, 12, 43, 5, 34 };
            var array = GenerateArray(l);
            int[] B = { };
            foreach (var e in array)
                Console.Write(e + " ");
            QuickSort(array);
            Console.WriteLine();
            foreach (var e in array)
                Console.Write(e + " ");
            Console.ReadLine();
        }

        public static void QuickSort(int[] array)
        {
            if (array.Length > 1)
            {
                QuickSort(array, 0, array.Length - 1);
            }
        }

        public static int[] GenerateArray(int length)
        {
            int[] array = new int[length];
            Random rand = new Random();
            for (int y = 0; y < length; y++)
            {
                array[y] = rand.Next(0, 50);
            }
            return array;
        }

        public static void QuickSort(int[] array, int low, int high)
        {
            while (low < high)
            {
                    var pivot = array[high];
                    i = low;
                    for (int j = low; j <= high - 1; j++)
                    {
                        if (array[j] <= pivot)
                        {
                            var t = array[i];
                            array[i] = array[j];
                            array[j] = t;
                            i += 1;
                        }
                    }
                    var n = array[i];
                    array[i] = array[high];
                    array[high] = n;
                    var extraLow = low;
                    var extraHigh = high;
                    if (i - low <= high - i)
                    {
                        QuickSort(array, low, i - 1);
                        low = i + 1;
                    }
                    else
                    {
                        QuickSort(array, i + 1, high);
                        high = i - 1;
                    }
            }
        }
    }
}
