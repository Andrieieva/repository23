using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WindowHeight = 20;
        Console.WindowWidth = 44;
        int screenwidth = Console.WindowWidth;
        int screenheight = Console.WindowHeight;

        var game = new SnakeGame(screenwidth, screenheight);
        game.Run();
    }
}
