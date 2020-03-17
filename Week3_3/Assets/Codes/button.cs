using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class button : MonoBehaviour
{
    public GameObject player;
    float y0, y1;
    Vector3 Offset;
    public static bool pressDown=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //Offset = player.transform.eulerAngles;
    }

    public void Click(string buttonName)
    {
       
        pressDown = true;     
        //Debug.Log(pressDown);
        //Problem:次数过多
        Thread.Sleep(500);
        speed.changeSpeed();
    }
    public void ClickDown()
    {
        Offset = player.transform.eulerAngles;
        Debug.Log("5555555555555555:" + Offset);
        //y0 = player.transform.eulerAngles.y;
    }
    public void ClickOff()
    {

        //y1 = player.transform.eulerAngles.y;
        //Offset.y = Offset.y + y1 - y0;
        if (Input.touchCount <= 0)
        {
            player.transform.eulerAngles = Offset;
            Debug.Log("66666666666666666:" + Offset);
        }

        
    }
}
