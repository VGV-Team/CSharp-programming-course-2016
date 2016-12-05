using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake(10,10); // naredimo novo instanco razreda Snake

            while (true)
            {
                Thread.Sleep(250);
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.RightArrow)
                        snake.setDirection(MoveDirection.Right);
                    else if (key == ConsoleKey.LeftArrow)
                        snake.setDirection(MoveDirection.Left);
                    else if (key == ConsoleKey.UpArrow)
                        snake.setDirection(MoveDirection.Up);
                    else if (key == ConsoleKey.DownArrow)
                        snake.setDirection(MoveDirection.Down);
                }

                bool ok = snake.step();
                if (!ok) break;
            }
            Console.WriteLine("You have lost");

            Console.ReadKey();
        }
    }
}
