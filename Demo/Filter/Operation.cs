using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Filter
{
    //public delegate bool ElementDel<T>(T number);
    internal class Operation
    {
        public static List<T> GetElement<T>(List<T> Element , Predicate<T> CompareMethod )
        {
            List<T> returenedNumbers = new List<T>();
            if (Element is not null && CompareMethod is not null) 
            {
                for (int i = 0; i < Element.Count; i++)
                {
                    if (CompareMethod(Element[i]))
                    {
                        returenedNumbers.Add(Element[i]);
                    }
                }
            }
            return returenedNumbers;
        }

        //public static List<int> GetNumbers(List<int> nubmers) 
        //{
        //    List<int> returenedNumbers = new List<int>();
        //    for(int i = 0; i < nubmers.Count; i++) 
        //    {
        //        if (nubmers[i] % 2 == 0) 
        //        {
        //            returenedNumbers.Add(nubmers[i]);
        //        }
        //    }
        //    return returenedNumbers;
        //}


        public static bool isStringLargerThan3(string name) 
        {
            return name.Length > 3;
        }
        public static bool isOddNumber(int number) 
        {
            return number % 2 == 0;
        }

        public static bool isEvenNumber(int number)
        {
            return  number % 2 != 0;
        }

        public static bool isDevidedBy7(int number)
        {
            return number % 7 == 0;
        }

        public static bool isDevidedBy10(int number)
        {
            return number % 10 == 0;
        }


    }
}
