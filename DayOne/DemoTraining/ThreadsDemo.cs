using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoTraining
{
    static class ThreadsDemo
    {
        public static void Execute()
        {

            //var t = new Thread(PrintNames);
            //t.Start();
            //Thread one = new Thread(PrintNames);
            //one.Start();
            //Thread two = new Thread(PrintNumbers);
            PrintNames();
            PrintNames();
            PrintNumbers();
            PrintNumbers();
            //PrintNumbers();
            //two.Start();
        }

        public static void PrintNames()
        {
            List<string> names = new List<string> { "aaa", "bbb", "ccc", "ddd" };
            foreach (var item in names)
            {
                Thread.Sleep(500);
                Console.WriteLine(item);
            }
        }
        public static async void PrintNumbers()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40 };

            foreach (var item in numbers)
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(500);
                    Console.WriteLine(item);
                });
            }
        }



    }

}