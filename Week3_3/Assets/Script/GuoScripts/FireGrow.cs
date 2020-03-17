using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*控制火的增长合并
*每一簇火都动态增长，至一定程度后不再增长
* 
* 下面功能在
*每隔一段时间扫描周围环境，距离小于一定长度内出现火焰，则将两个合并成一个
*合并方式为，取较大的火，消灭小火，并将大火进行一定程度的增大
* 
*控制火的传播
* 每隔一段时间向外弹出小球，并将小球第一次与物体接触的点记录下来，然后在该位置生成一簇新的小火
* 
*/
public class FireGrow : MonoBehaviour
{
    public static float startSize=10.0f;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    private void FixedUpdate()
    {
        //整体成增长趋势
        //Debug.Log("FixedUpdate is called");
        //每隔一段时间动态增长
        //GameObject [] fires;
        //ParticleSystem ps;
        //fires=GameObject.FindGameObjectsWithTag("Fire");
        //foreach (GameObject fire in fires)
        //{
        //    //火势增长
        //    //var random = (10 * Random.value) / 2;
            
        //            Transform tr = fire.GetComponent<Transform>();
        //            foreach (Transform child in tr)
        //            {
        //                GameObject chi = child.gameObject;
        //                if (chi.name == "ColliderTest")
        //                {
        //                    //chi.GetComponent<BoxCollider>().size *= 2;
        //                    //Debug.Log(" collider of the test increased");
        //                    Vector3 v3 = chi.GetComponent<Transform>().localScale;
        //                    if (v3.x < 2)
        //                    {
        //                        v3.x *= 1.0001f;
        //                        v3.y *= 1.0001f;
        //                        v3.z *= 1.0001f;
        //                    }
        //                    chi.GetComponent<Transform>().localScale = v3;
        //                }
        //                else if (chi.name == "Flames" || chi.name == "Fires")
        //                {
        //                    Debug.Log(chi.name + " changed");
        //                    ps = chi.GetComponent<ParticleSystem>();
        //                    //ps.Stop();
        //                    var main = ps.main;
        //                    //ParticleSystem.MinMaxCurve cu = main.startSize;
        //                    if (startSize < 500)
        //                    {
        //                        startSize *= 1.0001f;
        //                        main.startSize = startSize;
        //                        Debug.Log(chi.name + " increased once");
        //                    }
        //                    //ps.Play();
        //                }
        //            }
        //        //    break;
        //        //case 1:
        //        //    break;
        //        //default:
        //        //    break;
        //    }
        //个体增长或减少

        Transform thisTr = this.gameObject.GetComponent<Transform>().parent.gameObject.GetComponent<Transform>();
        foreach(Transform child in thisTr)
        {
            if (child.name == "ColliderTest")
            {
                //chi.GetComponent<BoxCollider>().size *= 2;
                //Debug.Log(" collider of the test increased");
                 Vector3 v3 = child.GetComponent<Transform>().localScale;
                 if (v3.x < 1.5)
                 {
                    v3.x *= 1.00005f;
                    v3.y *= 1.00005f;
                    v3.z *= 1.00005f;
                 }
                child.GetComponent<Transform>().localScale = v3;
            }
            else if (child.name == "Flames" || child.name == "Fires")
            {
                //Debug.Log(child.name + " changed");
                ParticleSystem ps = child.GetComponent<ParticleSystem>();
                //ps.Stop();
                var main = ps.main;
                //ParticleSystem.MinMaxCurve cu = main.startSize;
                if (startSize < 50)
                {
                    startSize *= 1.0001f;
                    main.startSize = startSize;
                    //Debug.Log(child.name + " increased once");
                }
                //ps.Play();
            }
        }

        StartCoroutine(increaseByNum());
        //if((startSize>4)&&(startSize<5))
        //{
        //    //随机产生新火焰
        //    int x =(int) (Random.value * 10) % 4;
        //    Debug.Log("produce the random is " + x);
        //    switch(x)
        //    {
        //        case 0:
        //            Vector3 newV = this.gameObject.GetComponent<Transform>().position;
        //            //新的火焰位置设置
        //            //射线检测周围，无墙壁，则生成新火焰
        //            RaycastHit hit;
        //            bool isExist=Physics.Raycast(transform.position, Vector3.forward, out hit, 20.0f);
        //            if(!isExist)
        //            {
        //                newV.x += 10f;
        //                Instantiate(prefab, newV,Quaternion.identity);
        //                Debug.Log("produce a new fire");
        //            }               
        //            break;
        //        case 1:
        //            break;
        //        case 2:
        //            break;
        //        case 3:
        //            break;
        //        default:
        //            break;
        //            //只有当随机到0时才生成新火焰
        //    }
        }

    

    IEnumerator increaseByNum()
    {
        if(Random_fire.fireList.Count<100)
        {
             if ((startSize > 45) && (startSize < 50))
            {
                //随机产生新火焰
                int x = (int)(Random.value * 100) %97;
                //Debug.Log("produce the random is " + x);
                 if (x == 0)
                 {
                    Vector3 newV = this.gameObject.GetComponent<Transform>().position;
                    //新的火焰位置设置
                     //射线检测周围，无墙壁，则生成新火焰
                    RaycastHit hit;
                    bool isExist1 = Physics.Raycast(transform.position, Vector3.forward, out hit, 10.0f);
                    bool isExist2 = Physics.Raycast(transform.position, Vector3.back, out hit, 10.0f);
                    bool isExist3 = Physics.Raycast(transform.position, Vector3.left, out hit, 10.0f);
                    bool isExist4 = Physics.Raycast(transform.position, Vector3.right, out hit, 10.0f);
                    if (!isExist1)
                    {
                        newV.x += 5f;
                        Instantiate(prefab, newV, Quaternion.identity);
                        //Debug.Log("produce a new fire");
                    }

                    //只有当随机到0时才生成新火焰
             }
        }
        }

        yield return 1;
    }

 }
   


