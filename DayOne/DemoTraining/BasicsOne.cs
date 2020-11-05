using System;
namespace DemoTraining
{
    public class BasicsOne
    {
        public static void Execute() 
        {
            int a = 10;
            CS csOb = new CS();
            csOb.x = 10;
            Console.WriteLine("value of x is: " + csOb.x);
            Update(csOb);
            Console.WriteLine("value of x is: " + csOb.x);
            //ST stOb = new ST();
            //stOb.x = 10;
            //Console.WriteLine("value of x is: " + stOb.x);
            //Update2(stOb);
            //Console.WriteLine("value of x is: " + stOb.x);

            //     - * / %; && || ; > < >= <= != == ; = +=, -=, ++ --

            int x = 10;
            int y = 10;

            y += 10;

            x = x + 10;

            // x > y || z > t || m==0
            // if if-else switch 
            // for while do-while

            Console.WriteLine("x value " + x + " y value : " + y);
            Console.WriteLine($"x \"value\" {x} y \\value : {y}");

            int n = -10;
            if (n > 0)
            {
                if (n % 2 == 0 && n > 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("ODD");
                }
            }
            else
            {
                Console.WriteLine("Invalid!");
            }

            switch (n)
            {
                case 1:
                    Console.WriteLine("AK");
                    break;
                case 12:
                    Console.WriteLine("AK");
                    break;
                case 3:
                    Console.WriteLine("AK");
                    break;
                case 4:
                    Console.WriteLine("AK");
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }

        }
        static void Update(CS csParam) { csParam = null; }
        static void Update2(ST csParam) { csParam.x = 100; }

    }
    class CS
    {
        public int x;
        public int y;
    }
    struct ST
    {
        public int x;
        public int y;
    }
}
