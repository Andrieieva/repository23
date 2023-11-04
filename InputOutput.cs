using System.Xml.Linq;

class InputOutput
{
    public Direction GetNewDirection()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    return Direction.Up;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    return Direction.Down;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    return Direction.Left;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    return Direction.Right;
            }
        }
        return Direction.NoChange;
    }
}

enum Direction
{
    Up,
    Down,
    Left,
    Right,
    NoChange
}
