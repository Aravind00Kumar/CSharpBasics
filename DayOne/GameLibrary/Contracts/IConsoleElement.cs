using System;

namespace GameLibrary
{
    public interface IConsoleElement
    {
        int XPos { get; set; }
        int YPos { get; set; }
        string Content { get; set; }
        void Show();
        void Hide();

    }
}
