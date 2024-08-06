using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Search
{
    //public delegate TResult SortedArrayDel< in T , out TResult>(T n1, T n2);
    internal class BubbleSort<T>
    {
        public static void SortArray(T[] arr, Func<T,T,bool> reference)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (reference(arr[j], arr[j + 1]))
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }

        //public static void SortArray(int[] arr ,SortedArrayDel reference) 
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (reference(arr[j], arr[j+1]))
        //                {
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}


        //public static void BubbleSortASC(int[] arr) 
        //{
        //    if(arr is not null) 
        //    {
        //        for(int i = 0; i < arr.Length; i++) 
        //        {
        //            for(int j = 0; j < arr.Length - i - 1; j++) 
        //            {
        //                if (SortAsc(arr[j], arr[j + 1])) 
        //                {
        //                    Swap(ref arr[j],ref arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}

        //public static void BubbleSortDESC(int[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (SortDesc(arr[j], arr[j+1]))
        //                {
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}

        private static void Swap(ref T v1,ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }


        public static bool SortAsc(int n1 , int n2) 
        {
            return n1 > n2;
        }

        public static bool SortDesc(int n1, int n2)
        {
            return n1 < n2;
        }
        public static bool SortString(string s1 , string s2) 
        {
            return s1?.Length > s2?.Length;
        }

        public static bool SortStringDesc(string s1, string s2)
        {
            return s1?.Length < s2?.Length;
        }


    }
}
