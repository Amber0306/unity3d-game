using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//初始随机生成火焰
public class Random_fire : MonoBehaviour
{
    public GameObject fire;
    public static List<GameObject> fireList=new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        //将已有火焰放入
        GameObject[] nowfires;
        nowfires = GameObject.FindGameObjectsWithTag("Fire");
        foreach(GameObject fire in nowfires)
        {
            fireList.Add(fire);
        }
        //随机生成火焰，根据房屋中的具体数据变化
        //for (int i = 0; i < 5; i++)
        //{
        //    Instantiate(fire, new Vector3(Random.Range(-40f, 40f), 3f, Random.Range(-40f,40f)), Quaternion.identity);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
