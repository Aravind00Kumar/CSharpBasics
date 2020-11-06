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
        event
     */


    public class TestClass 
    {
        
        
        public event Action actionExecuting;

        public event Action<TestClass, string> Executing;

        public event Action TopSpeed;


        public int Speed { get; set; }

        public void TestExecute() 
        {
            Console.WriteLine("execution started....");

            //Executing.Invoke(this, "Execting the 2nd line");
            Console.WriteLine("execution executing....");

            Console.WriteLine("execution completed....");
        }

        public void IncreaseSpeed() {
            Speed++;

            //if (Speed > 120) {
                if(TopSpeed!=null) TopSpeed.Invoke();
            //}
        }

    }

    static class EventsDemo
    {
        public static void Execute()
        {
            TestClass tst = new TestClass();
            //tst.actionExecuting += OnExectingTheTest;
            //tst.actionExecuting += OnExectingTheTest;
            ////tst.actionExecuting = null;
            //tst.TestExecute();
            //tst.actionExecuting -= OnExectingTheTest;

            //tst.Executing += onExecutingTest;


            //tst.TopSpeed += () =>
            //{
            //    Console.WriteLine("");
            //};
            tst.TestExecute();
            tst.IncreaseSpeed();
            tst.IncreaseSpeed();
        }

        public static void OnExectingTheTest() {
            Console.WriteLine("Please Execute Main Method as well wehn you are executing the test");
        }

        public static void onExecutingTest(TestClass source, string message) {
            
        }

        //public static void PrintMessage() 
        //{
        //    Console.WriteLine("Print Message");
        //}

    }

}