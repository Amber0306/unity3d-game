using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Maincameraquit : MonoBehaviour
{
    // Start is called before the first frame update
    public Button buttonok;

    public void onbuttonquit()
    {


        //退出游戏
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
          Application.Quit();
#endif

    }

    // Update is called once per frame


}

