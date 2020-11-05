//using System;
//namespace DemoTraining
//{
//    public class BasicsClass
//    {
//        public static void Execute() 
//        {
            
//        }
//    }
//    // private public internal
//    class Flight2 
//    {
//        private int x;
//        public int y;
//        int z;

//        public int Z 
//        {
//            get { return z; }
//            set { z = value; }
//        }

//        public int H { get; set; }

//        public int getX()
//        {
//            return x; 
//        }
//        public void setX(int value)
//        {
//            x = value;
//        }


//        public void MoveLeft()
//        {

//        }
//        public void MoveRight()
//        {

//        }

//        public void Display() 
//        {
//            Console.SetCursorPosition(x, y);
//            Console.Write("^");
//        }
//    }

//    class Flight 
//    {
//        public int XPos { get; set; }
//        public int YPos { get; set; }

//        public Flight(int xpos, int ypos)
//        {
//            XPos = xpos;
//            YPos = ypos;
//        }

//        public void Init(int xpos, int ypos) 
//        {
//            XPos = xpos;
//            YPos = ypos;
//        }

//        public void Init(float xpos, float ypos)
//        {
           
//        }

//        public void MoveLeft()
//        {
//            if (XPos - 1 >= 1)
//            {
//                --XPos;
//            }
//        }
//        public void MoveRight()
//        {
//            if (XPos + 3 <= 120) { 
//                ++XPos;
//            }
//        }
//        private void Clear() {
//            Console.SetCursorPosition(XPos-1, YPos);
//            Console.Write("   ");
//        }
//        public void Display()
//        {
//            Clear();
//            Console.SetCursorPosition(XPos, YPos);
//            Console.Write("^");
//        }


//    }
//}


////Console

