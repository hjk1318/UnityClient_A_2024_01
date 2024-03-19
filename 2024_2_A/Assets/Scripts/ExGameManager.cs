using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExGameManager : MonoBehaviour
{

    public ExGameData gamedata;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Name : " + gamedata.gameName);
        Debug.Log("Game Score : " + gamedata.gameScore);
        Debug.Log("Is Game Active : " + gamedata.isGameActive);
    }
}
