using System;

namespace GameLibrary
{
    public class Missile : MovableConcoleElement
    {
        public Missile(int xpos, int ypos)
        {
            XPos = xpos;
            YPos = ypos;
        }

        public void Show()
        {
            Hide();
            Console.SetCursorPosition(XPos, YPos);
            Console.Write("#");
        }
    }
}
