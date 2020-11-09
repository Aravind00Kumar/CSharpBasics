using System;

namespace GameLibrary
{
    public class Bullet : MovableConcoleElement, IConsoleElement, IConsoleMovableElement
    {
        public Bullet(int xpos, int ypos) : base(xpos, ypos, 10000000 / 6, "*")
        {
        }
    }
}
