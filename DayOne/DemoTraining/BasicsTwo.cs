using System;
namespace DemoTraining
{
    public class BasicsTwo
    {
        public static void ForLoop() 
        {
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int n = 10;
            for (int i = 0; i < n; i+=2)
            {
                for (int j = 0; j < (n - i) / 2; j++)
                {
                    Console.Write(" ");
                }
                int k = 0;
                while (k <= i)
                {
                    Console.Write("*");
                    k++;
                }
                Console.Write("\n");
            }


        }

        public static void WhileLoop()
        {
            int n = 10;
            /*
                    *
                   ***
                  *****
                 *******
             */
            int i = 0;
            while(i < 20)
            {
                Console.WriteLine(i);
                i++;
            }
        }

    }
}
