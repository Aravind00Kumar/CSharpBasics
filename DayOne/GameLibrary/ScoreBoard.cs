using System;
using System.Dynamic;
using System.Xml.Linq;

namespace GameLibrary
{
    public class ScoreBoard : ConsoleElement, IConsoleElement
    {
        public ScoreBoard(int xpos, int ypos, string content): base(xpos, ypos, content) {
        }
    }
}
