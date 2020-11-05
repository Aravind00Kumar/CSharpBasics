using System;

namespace GameLibrary
{
    public class Bullet : MovableConcoleObject
    {
        public Bullet(int xpos, int ypos)
        {
            XPos = xpos;
            YPos = ypos;
        }

        public void Show()
        {
            Hide();
            Console.SetCursorPosition(XPos, YPos);
            Console.Write("0");
        }
    }
}
