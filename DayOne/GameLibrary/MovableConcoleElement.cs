using System;

namespace GameLibrary
{
    public abstract class MovableConcoleElement : ConsoleObject
    {
        private void MoveLeft()
        {
           if(XPos - 1 > 1) --XPos;
        }
        private void MoveRight()
        {
            ++XPos;
        }
        private void MoveTop()
        {
            --YPos;
        }
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Top:
                    MoveTop();
                    break;
                case Direction.Left:
                    MoveLeft();
                    break;
                case Direction.Right:
                    MoveRight();
                    break;
            }
        }
        public void Hide()
        {
            Console.SetCursorPosition(XPos - 1, YPos);
            Console.Write("   ");
            Console.SetCursorPosition(XPos, YPos + 1);
            Console.Write("   ");
        }
    }
}
