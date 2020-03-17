using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    //private static ETCJoystick myJoystick;
    // Start is called before the first frame update
    void Start()
    {
        //myJoystick = GetComponent<ETCJoystick>();
    }

    // Update is called once per frame
    public static void changeSpeed()
    {
        if (ani.bodyState == true)
        {

            //myJoystick.axisX.speed = 1;
            //myJoystick.axisY.speed = 1;
            //Debug.Log("Slow down");
        }
        else{
        //    myJoystick.axisX.speed = 6;
        //    myJoystick.axisY.speed = 6;
        }
    }
}
