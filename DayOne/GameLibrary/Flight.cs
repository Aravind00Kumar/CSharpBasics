using System;

namespace GameLibrary
{
    public class Flight : MovableConcoleElement
    {
        public Flight(int xpos, int ypos)
        {
            XPos = xpos;
            YPos = ypos;
        }
        public void Show()
        {
            Hide();
            Console.SetCursorPosition(XPos, YPos);
            Console.Write("^");
        }
    }
}
