using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTip : MonoBehaviour
{
    private bool IsTip = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (IsTip)
            {
                GameObject.Find("Tip").GetComponent<ShowTip>().show("厕所提示");
                IsTip = false;
            }
        }
    }
}
