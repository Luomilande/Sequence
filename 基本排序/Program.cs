using System;

namespace 基本排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 3, 5, 2, 8, 11, 12, 1 };
            InsertionSort(a);
        }

        /// <summary>
        /// 冒泡算法（Bubble Sort）
        /// <br>时间复杂度：一层循环for为o(n)，两层双嵌套为o(n^2)</br>
        /// <br>思想：第一个for循环一次大的，子for中将前后的数字进行比较调换位置。</br>
        /// <br>flag起到的作用是，当子for为循环完时发现排序以完全，将直接退出循环。</br>
        /// </summary>
        /// <param name="arr">数组</param>
        public static void BubbleSort(int[] arr)
        {
            int temp;
            bool flag;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                flag = false;
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        flag = true;


                        for (int a = 0; a < arr.Length; a++)
                        {
                            Console.Write(arr[a] + ",");
                        }
                        Console.WriteLine("----------------");

                    }
                }
                if (!flag) break;
            }
        }

        /// <summary>
        /// 选择排序（Selction Sort）
        /// <br>时间复杂度：O(n2)</br>
        /// <br>思想：根据数组长度，挨个下标遍历，向后匹配找出最小值进行位置交换。</br>
        /// </summary>
        /// <param name="arr">数组</param>
        public static void SelctionSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //配大小
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }
                //通过匹配大小，找出后面中的最小值进行交换，如果大小相等则不进行交换。
                if (arr[minIndex] != arr[i])
                {
                    temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;

                    for (int a = 0; a < arr.Length; a++)
                    {
                        Console.Write(arr[a] + ",");
                    }
                    Console.WriteLine("----------------");
                }
            }

        }

        /// <summary>
        /// 插入排序（Insertion Sort）
        /// <br>时间复杂度：O(n2)</br>
        /// <br>思想：n-1为排序号的，将n插入到n-1中。</br>
        /// </summary>
        /// <param name="arr">数组</param>
        public static void InsertionSort(int[] arr)
        {
            int temp;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j > 0; j--)
                {
                    if (arr[j] < arr[ j-1])
                    {
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;

                        for (int a = 0; a < arr.Length; a++)
                        {
                            Console.Write(arr[a] + ",");
                        }
                        Console.WriteLine("----------------");

                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
