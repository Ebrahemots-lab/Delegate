using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public static class ListMethods<T>
    {
        public static bool Exist(List<T> list, Predicate<T> match)
        {
         for(int i = 0; i < list.Count; i++) 
            {
                if (match(list[i])) 
                {
                    return true;   
                }
            }
            return false;
        }


        public static string Find(List<T> list, Predicate<T> match) 
        {
            string element = "";
            for(int i = 0; i < list.Count; i++) 
            {
                if (match(list[i])) 
                {
                    element = list[i].ToString()!;
                }
            }
            return element;
        }


        public static List<T> FindAll(List<T> list, Predicate<T> match) 
        {
            List<T> returnedList = new List<T>();
            if(list is not null) 
            {
                for(int i = 0; i < list.Count; i++) 
                {
                    if (match(list[i])) 
                    {
                        returnedList.Add(list[i]);
                    }
                }
            }

            return returnedList;
        }

        public static int FindIndex(List<T> list, Predicate<T> match) 
        {
            int index = 0;
            if(list is not null) 
            {
                for(int i = 0; i < list.Count; i++) 
                {
                    if (match(list[i])) 
                    {
                        index = i;
                    }
                }
            }
            return index;
        }

        public static T FindLast(List<T> arr , Predicate<T> match) 
        {
        
            for(int i = arr.Count -1 ; i >= 0; i--) 
            {
                if (match(arr[i])) 
                {
                    return arr[i];
  
                }
            }

            throw new Exception("No Matching..");
            
        }

        public static int FindLastIndex(List<T> arr, Predicate<T> match)
        {
            //[1,2,3,4,2]
            int index = 0;
            int counter = 0;
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                counter++;
                if (match(arr[i]))
                {
                    index = arr.Count - counter;
                    break;
                }
            }

            return index;
        }

        public static void Foreach(List<T> list,Action<T> action) 
        {
            foreach(T item in list) 
            {
                action(item);
            }
        }

       public static bool TrueForAll(List<T> list, Predicate<T> match) 
        {
            bool isValid = false;
            for(int i = 0; i < list.Count; i++) 
            {
                if (match(list[i])) 
                {
                    isValid = true;
                }
                else 
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

    }


}
