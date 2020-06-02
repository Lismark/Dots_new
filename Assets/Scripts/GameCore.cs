using UnityEngine;
using System;
public class GameCore
{
    public int[,] gameField;
    private int sizeX;
    private int sizeY;

    public GameCore(int sizeX, int sizeY)
    {
        this.sizeX = sizeX;
        this.sizeY = sizeY;
        gameField = new int[sizeX, sizeY];
        InitField();
    }

    private void InitField()
    {
        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                gameField[i, j] = i;
                
            }
        }
    }
    public enum Direction
    {
        Nope,
        Left,
        Up,
        Right,
        Down
    }

    public bool Move(int x, int y, Direction dir)
    {
        switch(dir)
        {
            case Direction.Nope:
                Console.WriteLine("Stop");
                return false;

            case Direction.Left:
                ShiftHorizontal(x, y, dir);
                return true;

            case Direction.Right:
                ShiftHorizontal(x, y, dir);
                return true;

            case Direction.Up:
                Console.WriteLine("Up");
                return true;

            case Direction.Down:
                Console.WriteLine("Down");
                return true;

            default: return false;
        }
    }

    private void ShiftHorizontal(int x, int y, Direction dir)
    {

        if(dir == Direction.Left)
        {
          var tmp = gameField[x,sizeX-1];
          for(int i = sizeX -1 ; i > 0; i--)
            {
                gameField[i, y] = gameField[i - 1, y];
            }
            gameField[0, y] = tmp;
        }
        
        if(dir == Direction.Right)
        {
            var tmp = gameField[0,y];
            for(int i = 0; i < sizeX -1; i++)
            {
                gameField[i, y +1] = gameField[i, y];
            }
            gameField[0, y] = tmp;
        }
    }

    private bool IsComplete()
    {
        for(int i = 0; i < sizeX; i++)
        {
            for(int j = 0; j < sizeY; j++)
            {
                if(gameField[i,j] != gameField[i+1, j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}
