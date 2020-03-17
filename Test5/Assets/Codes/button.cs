using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class button : MonoBehaviour
{
    public static bool pressDown=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click(string buttonName)
    {
        pressDown = true;
        //Debug.Log(pressDown);
        //Problem:次数过多
        Thread.Sleep(500);
        speed.changeSpeed();
    }
}
