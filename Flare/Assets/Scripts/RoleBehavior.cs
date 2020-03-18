using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//测试角色碰撞火焰行为
public class RoleBehavior : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("role go to the foward");
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("role go to left");
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("role go to the back");
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("role go to the right");
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }
    }

    //碰撞开始  
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="FireBlock1")
        {
            Debug.Log("进入碰撞,碰撞名称："+collision.gameObject.name);
            //collision.gameObject.GetComponent<TargetScript>().Log(Message);
        }
        else if (collision.gameObject.name == "FireBlock2")
        {
            Debug.Log("进入碰撞,碰撞名称：" + collision.gameObject.name);
            //collision.gameObject.GetComponent<TargetScript>().Log(Message);
        }
        else if (collision.gameObject.name == "FireBlock1")
        {
            Debug.Log("进入碰撞,碰撞名称：" + collision.gameObject.name);
            //collision.gameObject.GetComponent<TargetScript>().Log(Message);
        }
    }

    ////碰撞中  
    //void OnCollisionStay(Collision collision)
    //{     if(collision.gameObject.name=="Sphere")
    //    {
    //        Debug.Log("碰撞中,碰撞名称：" +collision.gameObject.name);
    //    }
    //}
    ////碰撞结束  
    //void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.name=="Sphere")
    //    {
    //        Debug.Log("碰撞结束,碰撞名称："+collision.gameObject.name);
    //    }
    //}  
}
