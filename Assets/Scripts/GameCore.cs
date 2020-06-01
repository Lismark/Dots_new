using UnityEngine;
public class GameCore
{
    private int[,] gameField;
    private int sizeX;
    private int sizeY;

    public GameCore(int sizeX, int sizeY)
    {
        this.sizeX = sizeX;
        this.sizeY = sizeY;
        gameField = new int[sizeX, sizeY];
    }

    public enum Direction
    {
        Nope,
        Left,
        Up,
        Right,
        Down
    }

    public bool Move(int i, int j, Direction dir)
    {
        switch(dir)
        {
            case Direction.Nope:
                Debug.Log("Stop");
                return false;

            case Direction.Left:
                Debug.Log("Left");
                return true;

            case Direction.Right:
                Debug.Log("Right");
                return true;

            case Direction.Up:
                Debug.Log("Up");
                return true;

            case Direction.Down:
                Debug.Log("Down");
                return true;

            default: return false;
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
