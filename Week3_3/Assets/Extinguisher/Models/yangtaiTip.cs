using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yangtaiTip : MonoBehaviour
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
            GameObject.Find("Tip").GetComponent<ShowTip>().show("阳台通风，是个避难的好场所");
            isTip = false;
        }
    }
}
