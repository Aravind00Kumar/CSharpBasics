using System;

namespace GameLibrary
{
    public abstract class MovableConcoleElement : ConsoleElement, IConsoleMovableElement
    {
        public MovableConcoleElement(int xpos, int ypos, int speed, string content) : base(xpos, ypos, content) {
            Speed = speed;
        }
        public int Speed { get ; set ; }
        private long _ticks = 0;
        private bool isTimeEllapsed()
        {
            if (_ticks == 0)
                _ticks = DateTime.Now.Ticks; // 1000000 - sec //12
            if (DateTime.Now.Ticks > Speed + _ticks)
            {
                _ticks = 0;
                return true;
            }
            return false;
        }
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
            if (isTimeEllapsed()) { 
                --YPos;
            }
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
    }
}
