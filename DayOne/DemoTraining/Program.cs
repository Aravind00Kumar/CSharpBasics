using System;
using System.IO;
using DemoTraining;
using GameLibrary;
namespace DemoTraining2
{
    class Program
    {
        static void Main()
        {
            //BasicsOne.Execute();
            //BasicsTwo.ForLoop();
            //BasicsTwo.WhileLoop();
            //BasicsThree.Execute();
            //BasicsClass.Execute();

            //BasicsFour.Execute();
            //try
            //{
            //    MultipleValues.Execute();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //GenericsExample.Execute();

            Game flightGame = new Game();
            flightGame.Run();


            Console.ReadKey();

        }

    }

   
}
