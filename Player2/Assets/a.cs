using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : UnityEngine.MonoBehaviour
{  
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
        if (collision.transform.tag == "Player")
        {           
            GameObject.Find("Tip").GetComponent<ShowTip>().show("111111111111111111");
            GameObject.Find("Main Camera").GetComponent<MainCameraTips>().ShowWin();
        }
    }
}
