using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClass : MonoBehaviour
{
    void Start()
    {
        var gc = new GameCore(4,6);
        gc.Move(0, 0, GameCore.Direction.Left);

        Debug.Log(gc);
    }

}
