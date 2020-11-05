using System;
namespace DemoTraining
{
    public class BasicsThree
    {
        public static void Execute() 
        {
            //int a = 10, b = 20;
            //Console.WriteLine($"a is {a}, b is {b}");
            //Swap(ref a, ref b);
            //Console.WriteLine($"a is {a}, b is {b}");

            //int x = 10;
            //long y = x;
            //int z = (int) y;
            //string number = "100";
            //int num = int.Parse(number);
            //object objNum = "10023sds";
            //Convert.ToInt32(objNum);
            //Console.WriteLine(num/2);
            //Console.WriteLine(y);
            //int x = 10;
            //object y = x;
            //long z = (long) y;
            //int a1 = 10, a2 = 20;
            //bool result;
            //Console.WriteLine(Add(a1, a2, out result));
            //string salary = "10re00";
            //int sal = 1;
            //int.TryParse(salary, out sal);
            //int d = int.Parse(salary);
            //Console.WriteLine((sal * 10 / 100) + sal);
            int aa = 10;
            Console.WriteLine("value" + aa);
        }

        public static void Swap(ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int Add(int a, int b, out bool flag) {
            
            if (a > 0 && b > 0)
            {
                flag = true;
            }
            else {
                flag = false;
            }
            return a + b;
        }


    }
}
