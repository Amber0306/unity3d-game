using System;
using UnityEngine;
using HedgehogTeam.EasyTouch;

//挂载到Canvas上
public class CharactorRotate:MonoBehaviour
{
    //首先定义一个矩形作为判定区
    private Rect myRect=new Rect(0,0,395,1045);
    public GameObject player;
    public GameObject cameraCtrl;
    Vector2 gestureStartPosition=new Vector2(0,0);
    Vector2 gestureEndPosition= new Vector2(0, 0);
    Vector2 distance;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        cameraCtrl = GameObject.Find("CameraCtrl");
        EasyTouch.On_TouchStart += MyTouchStart;  //  开始触摸瞬间
        EasyTouch.On_TouchUp += MyTouchUp;  //停止触摸 
    }

    void Update()
    {
        if (myRect.Contains(gestureStartPosition))
        {
            //如果结束点也在矩形内
            if (myRect.Contains(gestureEndPosition))
            {
              
            }
        }
        else
        {
            return;
        }
    }

    void MyTouchStart(Gesture gesture)//注册触摸事件的自定义方法, 参数是Gesture
    {
       
        //Debug.Log("起点坐标为" + gesture.position);
        gestureStartPosition =gesture.position;
    }
    void MyTouchUp(Gesture gesture)
    {
        //Debug.Log("终点坐标为" + gesture.position);
        gestureEndPosition = gesture.position;

        //人物旋转
        distance = gestureEndPosition - gestureStartPosition;
        float x = distance.x;
        float ration = x / Screen.width;
        //计算旋转角度
        float rotation = ration * 360;
        //Debug.Log(rotation);
        if (player == null)
        {
            Debug.Log("null");
            Start();
        }
        player.transform.Rotate(0, rotation, 0);
        cameraCtrl.transform.Rotate(0, rotation, 0);//321
    }
}

