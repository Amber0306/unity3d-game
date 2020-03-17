using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ani : MonoBehaviour
{
    public CharacterController myCharacterController;
    public Animator playAnimator;
    public Rigidbody myRigidBody;
    public static bool bodyState = true;//1为站立，0为蹲下
    public bool bodyWillRun = false;
    public bool downBodyWillRun = false;
    public float speed = 0.2f;
    void Start()
    {
        playAnimator = GetComponent<Animator>();
        myCharacterController = GetComponent<CharacterController>();
        myRigidBody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        //由于人物控制器无法受重力控制，所以需要给控制器一个速度



        ////如果切换姿势
        //if (bodyState == true && button.pressDown == true)
        //{
        //    bodyState = false;
        //    playAnimator.Play("DownToLower");
        //    button.pressDown = false;
        //    playAnimator.SetBool("down", true);
        //}
        //else
        //{
        //    if (button.pressDown == true)
        //    {

        //        myCharacterController.SimpleMove(new Vector3(0, 1, 0));
        //        bodyState = true;
        //        playAnimator.Play("UpToHigher");
        //        // playAnimator.SetBool("down", true);
        //        button.pressDown = false;

        //    }
        }
    }

    //行走，分蹲下与站立两种状态下
//    public void walk()
//    {
//        if (bodyState == true)
//        {
//            //获取摇杆偏移量
//            //  float joyPositionX = leftJoystick.joystickAxis.x;

//            //用LookAt函数更改人物方向
//            if (!myCharacterController.isGrounded)
//            {
//                myCharacterController.SimpleMove(new Vector3(0, 0, 0));
//            }
//            playAnimator.Play("Running");
//        }
//        else
//        {
//            playAnimator.Play("DownWalk");
//        }
//    }

//    //等待，分蹲下与站立两种状态下
//    public void still()
//    {
//        if (bodyState == true)
//        {
//            playAnimator.Play("Still");
//        }
//        else
//        {
//            playAnimator.Play("DownState");
//        }
//    }

//}