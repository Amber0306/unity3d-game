using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameObject dialogLost;
    public static GameObject dialogWin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void gameWin()
    {
        dialogWin.SetActive(true);
    }

    public static void gameLose()
    {
        dialogLost.SetActive(true);
    }
}
