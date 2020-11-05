using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoTraining
{
    public class Employee<T,U>
    {
        public T Salary { get; set; }
        public U Bonus { get; set; }
    }
    public static class MultipleValues
    {
        public static void Execute() {
            //array

            int x = 10;

            int[] values = { 10, 20, 30, 40, 50 }; // 10 : index 0, 20 index 1

            ArrayList names = new ArrayList();
            //Stack

            names.Add("Aravind");
            names.Add(10);
            names.Add("Apple");
            names.Add(12.25f);

            Console.WriteLine(x);

            Console.WriteLine(values[2]); // value[index]

            values[2] = 1000;

            //Console.WriteLine(values[5]);

            Print(names);

            int a1 = 10, a2 = 20;

            Console.WriteLine($"a1 is {a1}, a2 is {a2}");
            GenericSwap<int>(ref a1, ref a2);
            Console.WriteLine($"a1 is {a1}, a2 is {a2}");


            float f1 = 10.1f, f2 = 20.2f;

            Console.WriteLine($"f1 is {f1}, f2 is {f2}");
            GenericSwap<float>(ref f1, ref f2);
            Console.WriteLine($"f1 is {f1}, f2 is {f2}");


            Employee<int, float> emp = new Employee<int, float>();
            emp.Salary = 10000;
            Console.WriteLine(emp.Salary);

            Employee<float,float> ge = new Employee<float,float>();
            ge.Salary = 10000.12f;
            Console.WriteLine(ge.Salary);


            List<int> numbers = new List<int> { 10, 20, 40 };
            numbers.Add(10);


            List<string> strings = new List<string>() { "foo" };

            strings.Add("moo");
            strings.Add("doo");

            PrintStrings(strings);

            //foreach (string item in strings)
            //{
            //    Console.WriteLine(item);
            //    if (item == "foo") strings.Add("eoo");
            //}

            //for (int i = 0; i < strings.Count; i++)
            //{
            //    Console.WriteLine(strings[i]);
            //    if (strings[i] == "foo") strings.Add("eoo");

            //}
            int value = 0;
            int tryX;

            //if (value <= 0) {
            //    Console.WriteLine("Invalid Value Boseus is set to default 3%");
            //    value = 3;
            //}
            try
            {
                foreach (string item in strings)
                {
                    Console.WriteLine(item);
                    if (item == "foo") strings.Add("eoo");
                }

                tryX = 10 / value;

            }
            //catch (Exception e)
            //{
            //    Console.WriteLine("Zero Error");
            //    throw new Exception("E001 : I dont like you!");
            //}
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Zero Error");
                throw new Exception("E001 : I dont like you!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Zero Error");
                throw new Exception("E001 : I dont like you!");
            }
            finally
            {

            }
            Console.WriteLine("Continue...");

        }

        public static void PrintStrings(List<string> values) 
        {
            //for (int i = 0; i < values.Count; i++)
            //{
            //    Console.WriteLine(values[i]);
            //}
            foreach (string item in values)
            {
                Console.WriteLine(item);
            }

        }


        public static void GenericSwap<T>(ref T a, ref T b)
        {
            T teamp = a;
            a = b;
            b = teamp;
        }
        //public static void Swap(ref int a, ref int b)
        //{
        //    int teamp = a;
        //    a = b;
        //    b = teamp;
        //}

        //public static void Swap(ref float a, ref float b)
        //{
        //    float teamp = a;
        //    a = b;
        //    b = teamp;
        //}

        public static void  Print(ArrayList values) 
        {
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

    }
}

