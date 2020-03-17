using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StomTip : MonoBehaviour
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
            GameObject.Find("Tip").GetComponent<ShowTip>().show("一楼烟雾过大，需要匍匐前进");
            isTip = false;
        }
    }
}
