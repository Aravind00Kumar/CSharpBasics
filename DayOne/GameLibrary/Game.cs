using System;
using System.Threading;

namespace GameLibrary
{

    public class Game {

        const int XMAX = 120;
        const int YMAX = 30;
        public Game()
        {
            Console.SetWindowSize(XMAX, YMAX);
            Console.CursorVisible = false;
        }
        public void Run()
        {
            Flight flightObj = new Flight(XMAX / 2, YMAX - 2);
            flightObj.Show();
            Bullet bullet = null;
            Missile missile = null;
            
            do
            {
                ConsoleKeyInfo ch = Console.ReadKey(true);
                switch (ch.Key)
                {
                    case ConsoleKey.LeftArrow:
                        flightObj.Move(GameLibrary.Direction.Left);
                        break;
                    case ConsoleKey.RightArrow:
                        flightObj.Move(GameLibrary.Direction.Right);
                        break;
                    case ConsoleKey.UpArrow:
                        bullet = new Bullet(flightObj.XPos, flightObj.YPos - 2);
                        break;
                    case ConsoleKey.G:
                        missile = new Missile(flightObj.XPos, flightObj.YPos - 2);
                        break;

                    case ConsoleKey.E:
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }

                while (bullet != null) {
                    Thread.Sleep(200);
                    if (bullet.YPos <= 2)
                    {
                        bullet.Hide();
                        bullet = null;
                    }
                    else { 
                        bullet.Move(Direction.Top);
                        bullet.Show();
                    }
                }

                while (missile != null)
                {
                    Thread.Sleep(200);
                    if (missile.YPos <= 2)
                    {
                        missile.Hide();
                        missile = null;
                    }
                    else
                    {
                        missile.Move(Direction.Top);
                        missile.Show();
                    }
                }
                flightObj.Show();
            } while (true);
        }

    }

}
