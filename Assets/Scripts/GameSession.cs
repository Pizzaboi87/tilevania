using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    void Awake()
    {
        int numGameSession = findObjectsOfType<GameSession>().Length;
    }

    void Update()
    {

    }
}
