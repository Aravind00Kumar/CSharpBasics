using System;

namespace GameLibrary
{
    public class Flight : MovableConcoleElement, IConsoleElement
    {
        public Flight(int xpos, int ypos) : base(xpos, ypos, 0, "^") { }
    }
}
