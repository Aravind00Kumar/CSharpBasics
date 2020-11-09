using System;

namespace GameLibrary
{
    public class PrimaryGun : MovableConcoleElement, IConsoleElement, IConsoleMovableElement
    {
        public PrimaryGun(int xpos, int ypos) : base(xpos, ypos, 10000000 / 6, "$")
        {
        }
    }
}
