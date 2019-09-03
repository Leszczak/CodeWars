using System.Collections.Generic;
using System.Linq;
using System;
public class Finder
{
    private static int n;
    private static char[][] board;
    private static Stack<Position> positions;
    public struct Position
    {
        public int x;
        public int y;
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public static bool PathFinder(string maze)
    {
        n = maze.Split("\n").Length;
        board = maze.Split("\n").Select(s=>s.ToCharArray()).ToArray();
        positions = new Stack<Position>();
        Position curentPosition = new Position(0, 0);
        
        while (true)
        {
            //if found exit
            if (curentPosition.x == n - 1 && curentPosition.y == n - 1)
                return true;
            //mark I was here
            board[curentPosition.x][curentPosition.y] = ' ';
            //if can move south
            if (curentPosition.x + 1 < n 
                && board[curentPosition.x + 1][curentPosition.y] == '.')
            {
                positions.Push(curentPosition);
                curentPosition = new Position(curentPosition.x + 1, curentPosition.y);
                continue;
            }
            //if can move east
            else if (curentPosition.y + 1 < n
                && board[curentPosition.x][curentPosition.y + 1] == '.')
            {
                positions.Push(curentPosition);
                curentPosition = new Position(curentPosition.x, curentPosition.y + 1);
                continue;
            }
            //if can move north
            else if (curentPosition.x - 1 >= 0
                && board[curentPosition.x - 1][curentPosition.y] == '.')
            {
                positions.Push(curentPosition);
                curentPosition = new Position(curentPosition.x - 1, curentPosition.y);
                continue;
            }
            //if can move west
            else if (curentPosition.y - 1 >= 0
                && board[curentPosition.x][curentPosition.y - 1] == '.')
            {
                positions.Push(curentPosition);
                curentPosition = new Position(curentPosition.x, curentPosition.y - 1);
                continue;
            }
            else if(positions.Count>0)
            {
                curentPosition = positions.Pop();
                continue;
            }
            return false;
        }
    }
}