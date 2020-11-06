using System;
using System.Collections.Generic;
using System.Linq;
namespace DemoTraining
{
    /*
     * 
     * Class
     * enum
     * interface
     * delegate
     */

    /*
        Properties
        Fields
        Methods
     
     */


    //public delegate void PrintMessageDelegate();
    //public delegate void PrintMessageDelegate<T>(T a);
    //public delegate void PrintMessageDelegate<T,U>(T a, U u);

    static class DelegatesExample2 
    {
        public static void Execute() 
        
        {
            List<string> names = new List<string>() { "aravind", "kundan", "kumar", "aaa", "bala", "bb" };
            //names.Print();

            List<int> numbers = new List<int>() { 10, 20, 30 };
            numbers.Print();

            //SeacrhByCondition(names, MoreThan3CharCondition).Print();
            //SeacrhByCondition(names, StartsWithACondition).Print();
            //SeacrhByCondition(names, (value)=> { return value.EndsWith("b"); }).Print();
            //names.FindWhere((x) => x.StartsWith("k")).Print();
            var result = names.Where2(x => x.StartsWith("b"));
            
            names.Add("bababab");
            var result2 = names.FindWhere(x => x.StartsWith("b") && x.Length < 4);

            result.Print();
            result2.Print();
            //names.Print();
        }


        public static IEnumerable<string> Where2(this IEnumerable<string> values, Func<string, bool> condition)
        {
            foreach (var item in values)
            {
                if (condition(item))
                    yield return item;
            }
        }

        public static IEnumerable<T> GWhere<T>(this IEnumerable<T> values, Func<T, bool> predicate)
        {
            foreach (var item in values)
                if (predicate(item))
                    yield return item;
        }

        public static IEnumerable<string> FindWhere(this IEnumerable<string> values, Func<string, bool> condition) 
        {
            List<string> result = new List<string>();
            foreach (var item in values)
                if (condition(item))
                    result.Add(item);
            return result;
        }
        public static IEnumerable<string> SeacrhByCondition(IEnumerable<string> values, Func<string, bool> condition) 
        {

            List<string> result = new List<string>();
            foreach (var item in values)
            {
                //if (item.StartsWith("a"))
                //{
                //    result.Add(item);
                //}
                if (condition(item))
                {
                    result.Add(item);
                }
            }
            return result;

        }

        public static bool MoreThan3CharCondition(string value) {
            return value.Length > 3;
        }

        public static bool StartsWithACondition(string value)
        {
            return value.StartsWith("a");
        }

    }



    static class DelegatesExample
    {
        public static void Execute()
        {

            Action act = PrintMessage;
            act();


            Action<List<string>> Printing = Print;

            //Action<int, int, int>;

            //Func<int> del;
            Func<int, int> addDel = (x) =>
            {
                Console.WriteLine(x);
                return x + 1;
            };

            Func<int, int, int> add = (x,y) => x + y;


            var list = new List<string> { "aaa", "bbb" };

            Printing(list);


            PrintMessage();
            var delInstance = new Action(PrintMessage);
            delInstance += PrintMessage2;
            delInstance += () =>
            {
                Console.WriteLine("I am a Method3");
            };
            delInstance += delegate ()
            {
                Console.WriteLine("I am a Method4");
            };

            //delInstance();

        }

        public static void PrintMessage()
        {
            PrintMessage2();
            Console.WriteLine("I am a Method");
        }
        public static void PrintMessage2()
        {
            Console.WriteLine("I am a Method2");
        }

        public static void Print<T>(this IEnumerable<T> values)
        {
            Console.WriteLine();
            foreach (var item in values)
            {
                Console.Write($"{item}, ");
            }
            Console.Write($"\b\b");
        }
    }

    

}