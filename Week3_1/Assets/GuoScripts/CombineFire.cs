using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//检测火焰之间的碰撞及合并
public class CombineFire : MonoBehaviour
{
    
    public float coolDown = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coolDown -= Time.deltaTime;
        if (coolDown < 0)
        {
            //合并
            StartCoroutine(combine());
            coolDown += 10;//间隔
        }
    }

    //private void FixedUpdate()
    //{
    //    //StartCoroutine(combine());
    //}

    IEnumerator combine()
    {
        //RaycastHit hit;
        //// 可控制投射距离
        //bool isClosed = Physics.Raycast(transform.position, Vector3.forward, out hit, 20.0f, 1 << LayerMask.NameToLayer("FireDetector"));
        //if (isClosed)
        //{
        //    Debug.Log("the close is enough to make the combination");
        //    Debug.Log("the distance is " + hit.distance);
        //    Debug.Log("the object of the contaction is ：" + hit.collider.gameObject.name);
        //    //如果两个检测器距离很近，被检测
        //    if (hit.collider.gameObject.name == "ColliderTest")
        //    {
        //        //获取自己的父物体fire
        //        GameObject thisParent = this.gameObject.transform.parent.gameObject;
        //        //获取碰撞器的父物体fire
        //        GameObject otherParent = hit.collider.gameObject.transform.parent.gameObject;
        //        //比较两个火焰的大小（主要比较Flare)
        //        if (this.gameObject.GetComponent<Transform>().localScale.x < hit.collider.gameObject.GetComponent<Transform>().localScale.x)
        //        {
        //            //如果本物体比射线检测到的物体小
        //            //将射线检测到的物体增大
        //            Vector3 v3 = otherParent.GetComponent<Transform>().localScale;
        //            v3 = v3 * 1.001f;
        //            otherParent.GetComponent<Transform>().localScale = v3;
        //            //将本物体毁灭
        //            Destroy(thisParent);
        //            //将射线检测到的物体向中间移动一小段距离
        //            Vector3 distance = thisParent.GetComponent<Transform>().position - otherParent.GetComponent<Transform>().position;
        //            otherParent.GetComponent<Transform>().position += (distance / 2f);
        //        }
        //    }
        //}
        //else
        //{
        //    Debug.Log("no combination");
        //}
        //链表法检测
        int i, j;
        for (i = 0; i < Random_fire.fireList.Count; i++)
        {
            for (j = 1; j < Random_fire.fireList.Count; j++)
            {
                Vector3 v3 = Random_fire.fireList[i].GetComponent<Transform>().position -
                    Random_fire.fireList[i].GetComponent<Transform>().position;
                float distance = Mathf.Sqrt(v3.x * v3.x + v3.y + v3.y + v3.z * v3.z);
                if (distance < 2)
                {
                    GameObject tempFire1 = Random_fire.fireList[i];
                    GameObject tempFire2 = Random_fire.fireList[j];
                    if (tempFire1.GetComponent<Transform>().GetChild(0).GetComponent<Transform>().localScale.x <
                        tempFire2.GetComponent<Transform>().GetChild(0).GetComponent<Transform>().localScale.x)
                    {
                        Random_fire.fireList.Remove(tempFire1);
                        Destroy(tempFire1);
                    }
                    else
                    {
                        Random_fire.fireList.Remove(tempFire2);
                        Destroy(tempFire2);
                    }
                    Debug.Log("a fire is destroyed");
                }
            }
        }
        yield return 1;
    }

}
