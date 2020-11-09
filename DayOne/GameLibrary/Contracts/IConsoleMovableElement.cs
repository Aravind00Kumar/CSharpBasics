using System;

namespace GameLibrary
{
    public interface IConsoleMovableElement
    {
        int Speed { get; set; }
        void Move(Direction direction);
    }
}
