using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public void IsQuit(bool quit)
    {
        if (quit)
        {
            //退出游戏
            Application.Quit();
        }
    }

    // Update is called once per frame
    
}
