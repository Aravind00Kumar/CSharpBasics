using System;

namespace GameLibrary
{
    public class Missile : MovableConcoleElement, IConsoleElement, IConsoleMovableElement
    {
        public Missile(int xpos, int ypos) : base(xpos, ypos, 10000000 / 6, "#")
        {
        }
    }
}
