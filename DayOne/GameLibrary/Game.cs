using System;
using System.Threading;
using System.Collections.Generic;

namespace GameLibrary
{

    public class Game {

        const int XMAX = 120;
        const int YMAX = 30;
        private ScoreBoard score;
        List<MovableConcoleElement> ammunition;
        public Game()
        {
            Console.SetWindowSize(XMAX, YMAX);
            Console.CursorVisible = false;
            score = new ScoreBoard(XMAX - 15, 1, "10");
            score.Show();
            ammunition = new List<MovableConcoleElement>();
        }
        public void Run()
        {
            Flight flightObj = new Flight(XMAX / 2, YMAX - 2);
            flightObj.Show();
            MovableConcoleElement bullet = null;
            MovableConcoleElement missile = null;
            ConsoleKeyInfo ch;
            do
            {
                if (Console.KeyAvailable) { 
                    ch = Console.ReadKey(true);
                }
                switch (ch.Key)
                {
                    case ConsoleKey.LeftArrow:
                        flightObj.Hide();
                        flightObj.Move(GameLibrary.Direction.Left);
                        flightObj.Show();
                        break;
                    case ConsoleKey.RightArrow:
                        flightObj.Hide();
                        flightObj.Move(GameLibrary.Direction.Right);
                        flightObj.Show();
                        break;
                    case ConsoleKey.UpArrow:
                        ammunition.Add(new Bullet(flightObj.XPos, flightObj.YPos - 2));
                        break;
                    case ConsoleKey.G:
                        ammunition.Add(new Missile(flightObj.XPos, flightObj.YPos - 2));
                        break;

                    case ConsoleKey.P:
                        ammunition.Add(new PrimaryGun(flightObj.XPos, flightObj.YPos - 2));
                        break;
                    case ConsoleKey.E:
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
                for (int i = 0; i < ammunition.Count; i++)
                {
                    var item = ammunition[i];
                    if (item != null)
                    {
                        if (item.YPos <= 2)
                        {
                            item.Hide();
                            ammunition.Remove(item);
                        }
                        else
                        {
                            item.Hide();
                            item.Move(Direction.Top);
                            item.Show();
                        }

                    }
                }
                ch = default;
                
            } while (true);
        }

    }

}
