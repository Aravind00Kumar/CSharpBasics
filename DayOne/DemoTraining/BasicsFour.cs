using System;
namespace DemoTraining
{


    public enum Direction 
    {
        LEFT,
        RIGHT,
        TOP,
        BOTTOM
    }
    public class BasicsFour
    {
        public static void Execute() 
        {
            MyClass ob = new MyClass();
            ob.MyProperty = 10;

            MyClass ob2 = new MyClass();
            ob2.MyProperty = 10;

            //MyClass.PrintMessage();

            ob.PrintMessage2();
        }
    }

    public static class Utils 
    {
        public static string GetGUID() 
        {
            return "123ed-23344f-22111-3344fd-23454";
        }
    }

    public class MyClass 
    {
        readonly float PI = 3.1416f;
        public int MyProperty { get; set; }
        public static int MyProperty2 { get; set; }

        //public Direction Dir { get; set; }

        public MyClass() 
        {
            PI = 3.14f;
            //Dir = Direction.LEFT;
        }
        public static void PrintMessage() 
        {
            Console.WriteLine("Welcome!");
        }

        public void PrintMessage2()
        {
            Console.WriteLine("Welcome!" + int.MaxValue);
            //PI = 121.2f;
        }

    }

}
