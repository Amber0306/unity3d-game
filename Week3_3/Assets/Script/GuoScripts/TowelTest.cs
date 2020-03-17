using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowelTest : MonoBehaviour
{
    public CharacterController myCharacterController;
    // Start is called before the first frame update
    public bool isTake;
    public Animator myAnimator;

    void Start()
    {
        isTake = false;
        //myCharacterController = this.gameObject.GetComponent<CharacterController>();
        myAnimator = myCharacterController.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(" update is called once ");
        myCharacterController.Move(new Vector3(0, 0, 0));
        //if(LeftButton.isStill)
        //{
        //    isHit();
        //}     
    }

    //碰撞触发方法
    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    GameObject hitObject = hit.collider.gameObject;
    //    //如果碰撞到了毛巾摆放处的洗手池
    //    if (hitObject.name == "sink01_2")
    //    {
    //        Debug.Log("the player hit the wash sink");
    //        //判断是否拿了毛巾，如果没有拿
    //        if (!isTake)
    //        {
    //            Debug.Log("execute the getting towel action");
    //            //执行拿毛巾动作，调用拿毛巾捂住口鼻动画
    //            myAnimator.Play("PickTowel");
    //            myAnimator.SetBool("Pick", true);
    //            //修改为已经拿过毛巾
    //            isTake = true;
    //            Debug.Log("has taken the towel");
    //            myAnimator.SetBool("PickTowel", true);
    //        }
    //    }
    //}


   
     //鼠标点击触发
    private void OnMouseDown()
    {
        Debug.Log("detect the towel is clicked");
        Vector3 pos = myCharacterController.gameObject.GetComponent<Transform>().position;
        GameObject[] washPools = GameObject.FindGameObjectsWithTag("Pool");
        foreach (GameObject pool in washPools)
        {
            Vector3 popos = pool.GetComponent<Transform>().position;
            float distance = Vector3.Distance(pos, popos);
            Debug.Log("the distance between the pool and the player is " + distance);
            if (distance < 3f)
            {
                Debug.Log("the player hit the wash sink");
                //判断是否拿了毛巾，如果没有拿
                if (!isTake)
                {
                    Debug.Log("execute the getting towel action");

                    //myAnimator.SetBool("Pick", true);
                    //将毛巾拿下
                    //找到对应毛巾
                    Transform towels = GameObject.Find("Towels").GetComponent<Transform>();
                    foreach (Transform child in towels)
                    {
                        float to_player = Vector3.Distance(child.position, pos);
                        Debug.Log("the distance between the player and the towel is " + to_player);
                        if (to_player < 6f)//找到毛巾
                        {
                            //child中的towel 为对应毛巾
                            foreach (Transform towel in child)
                            {
                                if (towel.name == "towel")
                                {

                                  //执行拿毛巾动作，调用拿毛巾捂住口鼻动画
                                    myAnimator.Play("PickTowel");

                                    //毛巾跟随人物
                                    Vector3 temp = pos;
                                    temp.y += 1.7f;
                                    temp.z += 0.2f;
                                    towel.position = temp;//改变位置
                                    Vector3 sca = towel.localScale;
                                    sca.z = sca.z / 2f;
                                    sca.x = sca.x / 2f;
                                    towel.localScale = sca;//改变大小

                                    //设为子物体
                                    towel.SetParent(myCharacterController.gameObject.GetComponent<Transform>());
                                    Debug.Log("the position of the towel is " + towel.position);
                                    //修改为已经拿过毛巾
                                    isTake = true;
                                    Debug.Log("has taken the towel");

                                }
                            }

                        }
                    }

                }
            }
        }
    }
}
