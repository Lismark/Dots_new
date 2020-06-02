using System;
using System.Collections.Generic;
using UnityEngine;

public class GameClass : MonoBehaviour
{
    void Start()
    {
        var gc = new GameCore(4,6);
        gc.Move(1, 0, GameCore.Direction.Left);
        Debugging(gc.gameField);

    }

    private void Debugging(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Debug.Log(array[i, j]);
            }
        }
    }

}
