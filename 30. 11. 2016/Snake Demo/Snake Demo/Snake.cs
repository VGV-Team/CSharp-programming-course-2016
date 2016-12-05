using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake_Demo
{
    class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    enum MoveDirection
    {
        Up,
        Down,
        Left,
        Right
    }

    class Snake
    {
        MoveDirection direction;

        public List<Point> body;

        public char[,] board;

        public int width;
        public int height;

        Point food;
        Random rand;

        public int delay;

        public Snake(int width, int height)
        {
            direction = MoveDirection.Right;
            body = new List<Point>();
            this.width = width;
            this.height = height;

            // Point tmpPoint = new Point(1, 2);
            // body.Add(tmpPoint);
            body.Add(new Point(1, 5));
            body.Add(new Point(1, 4));
            body.Add(new Point(1, 3));
            body.Add(new Point(1, 2));
            body.Add(new Point(1, 1));
            body.Add(new Point(1, 0));

            board = new char[height, width];

            //food = new Point(5, 5);
            rand = new Random();
            spawnFood();

            delay = 250;
        }

        private void spawnFood()
        {
            bool ok = true;
            int newX, newY;
            do
            {
                ok = true;
                newX = rand.Next(height);
                newY = rand.Next(width);
                foreach (Point item in body)
                {
                    if (item.x == newX && item.y == newY)
                    {
                        ok = false;
                        break;
                    }
                }
            }
            while (!ok);
 
            food = new Point(newX, newY);
        }

        public bool step()
        {
            Point p = null;
            switch (direction)
            {
                case MoveDirection.Up: 
                    p = new Point(body[0].x-1, body[0].y);
                    break;
                case MoveDirection.Down:
                    p = new Point(body[0].x + 1, body[0].y);
                    break;
                case MoveDirection.Left:
                    p = new Point(body[0].x, body[0].y - 1);
                    break;
                case MoveDirection.Right:
                    p = new Point(body[0].x, body[0].y + 1);
                    break;
                default:
                    break;
            }


            bool isMoveValid = checkMove(p);
            if (!isMoveValid) return false;
            body.Insert(0, p);
            

            if (food != null && food.x == body[0].x && food.y == body[0].y)
            {
                spawnFood();
                delay = (int)((double)delay * 0.9);
            }
            else
            {
                body.RemoveAt(body.Count - 1);
            }

            Console.Clear();
            refreshBoard();
            printBoard();

            return true;
        }

        public void setDirection(MoveDirection md)
        {
            direction = md;
        }


        public void refreshBoard()
        {
            board = new char[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    board[i, j] = '.';
                }
            }

            /*
            *       for (int i = 0; i < body.Count; i++)
            *       {
            *           board[body[i].x, body[i].y] = '#';
            *       }
            */

            foreach (Point item in body)
            {
                board[item.x, item.y] = '#';
            }
            board[body[0].x, body[0].y] = '0';

            if (food != null) board[food.x, food.y] = '$';
        }

        public bool checkMove(Point p)
        {
            // check if out of bounds
            if (p.x < 0 || p.y < 0 || p.x >= height || p.y >= height)
            {
                return false;
            }

            // check if collided with body
            for (int i = 1; i < body.Count-1; i++)
            {
                if (body[i].x == p.x && body[i].y == p.y) return false;
            }

            return true;
        }

        public void printBoard()
        {
            Console.WriteLine((body.Count-6) * 100);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(board[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
