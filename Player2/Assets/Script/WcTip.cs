using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WcTip : UnityEngine.MonoBehaviour
{
    private bool isTip = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (isTip)
        {
            GameObject.Find("Tip").GetComponent<ShowTip>().show("无路可逃时，可以利用卫生间进行避难，不要在可燃物多的地方避难，也不要乘坐电梯");
            isTip = false;
        }
    }
}
