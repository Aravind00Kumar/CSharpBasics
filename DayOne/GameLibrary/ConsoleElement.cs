using System;

namespace GameLibrary
{
    public class ConsoleElement: IConsoleElement
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        public string Content { get; set; }
        public ConsoleElement(int xpos, int ypos, string content)
        {
            XPos = xpos;
            YPos = ypos;
            Content = content;
        }

        public void Hide()
        {
            Console.SetCursorPosition(XPos, YPos);
            Console.WriteLine("".PadLeft(Content.Length));
        }

        public void Show()
        {
            Console.SetCursorPosition(XPos, YPos);
            Console.WriteLine(Content);
        }
    }
}
