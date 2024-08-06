using Demo.Search;
using Demo.Filter;

namespace Demo
{
    public delegate void PrintNames(string name);
   
    internal class Program
    {
        

        static void PrintFirstName(string name) 
        {
            Console.WriteLine($"Hello {name}");
        }

        static void PrintSecondName(string name) 
        {
            string[] arr = name.Split(" ");
            Console.WriteLine($"Hello {arr[1]}");
        }

        static void PrintMyName() { }
        static void Main(string[] args)
        {
            //Delegate
            //what is delegate?
            //it's like an object that hold a refernce for a method 
            //x = PrintMyName; // in this we hold the adress or reference of the method into X WITHOUT ()

            //Note : when we create a deleagate the compiler behind the scene create a class that inherit from some resoources

            //Defenation of delegate -> Acess Modifier - delagate - Return Type - DelegateName - (Params)

            //we can Simply say Delegate is a blueprint for method

            //Delegate signature and method signature must be matched..

            #region Delegate Ex01

            //PrintNames z = PrintSecondName; // this Printnames Reference refer to printHelloName Method


            ////we can Add another method to the same delegate 
            //z += PrintFirstName;

            //z.Invoke("Ebrahem ashraf");
            #endregion

            #region Delegate Ex02
            //int[] arr = { 4, 6, 2, 1, 9, 10 };

            //string[] names = { "ebrahem", "Ashraf", "ots", "aH", "Lo" };
            ////BubbleSort.BubbleSortASC(arr); //sort ASC
            ////BubbleSort.BubbleSortDESC(arr); //Sort Desc

            ////SortedArrayDel x = BubbleSort.SortDesc;

            //BubbleSort<string>.SortArray(names, BubbleSort<string>.SortStringDesc);

            //foreach (string name in names) 
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Delegate Ex03
            //List<int> numbers = Enumerable.Range(5,50).ToList();


            //List<int> result = Operation.GetNumbers(numbers , Operation.isEvenNumber);

            //foreach(int number in result) 
            //{
            //    Console.WriteLine(number);
            //}


            #endregion

            #region Delegate Ex04

            //List<int> numbers = Enumerable.Range(5, 50).ToList();


            //List<int> result = Operation.GetNumbers(numbers, Operation.isEvenNumber);

            //foreach (int number in result)
            //{
            //    Console.WriteLine(number);
            //}



            List<string> names = new List<string>() { "Ebrahem", "Ashraf", "Ots", "Aa" };

            List<string> newNames = Operation.GetElement(names, Operation.isStringLargerThan3);



            foreach (string name in newNames)
            {
                Console.WriteLine(name);
            }




            #endregion

            #region Built In Delegate
            //Predicit => will take one parameter and must return bool 

            //Func => will take 0 - 16 parameter and return something Func<T,T,Return>

            //Action => can refere to function take [0-16] paramteter and must be void

            #endregion


            #region Built In Delegate Examples

            //Predicate<double> fn1 = Test.isLargerThan3;
            //bool isLarg3 = fn1(3);
            //Console.WriteLine(isLarg3);

            //Func<int, int, int> fn2 = Test.Sum;
            //int result = fn2.Invoke(1, 2);
            //Console.WriteLine(result);

            //Action fn3 = Test.PrintName;
            //fn3.Invoke();

            //Action<string> fn4 = Test.PrintHello;
            //fn4("Ebrahem");


            #endregion


            #region Anonymous Function
            Predicate<double> p1 = delegate (double number) { return number > 3; };

            #endregion

            #region Lambda Expression
            Predicate<double> p2 =  (number) => number > 3; //number goes to number > 3 


           // var p3 = (int x) => x > 3 ? x : 0;

           //int result = p3.Invoke(2);

           //Console.WriteLine(result);
            #endregion
        }

      
    }

    class Test 
    {
        public static bool isLargerThan3(double number) {return number > 3;}

        public static int Sum(int n1 , int n2) 
        {
            return n1 + n2;
        }

        public static void PrintName() 
        {
            Console.WriteLine("Hello World");
        }

        public static void PrintHello(string name) 
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}

