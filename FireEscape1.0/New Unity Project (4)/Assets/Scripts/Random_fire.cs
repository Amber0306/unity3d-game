using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_fire : MonoBehaviour
{
    public GameObject fire;

    // Start is called before the first frame update
    void Start()
    {
        //随机生成火焰，根据房屋中的具体数据变化
        for (int i = 0; i < 5; i++)
        {
            Instantiate(fire, new Vector3(Random.Range(0f, 25f), -3, Random.Range(0f,20f)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
