using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOff : UnityEngine.MonoBehaviour
{
    public GameObject dialog;
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
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("aaa");
            dialog.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dialog.SetActive(false);
        }
    }
    public void OnClikTake()
    {
        GameObject.Find("Main Camera").GetComponent<MainCameraTips>().ShowLost();
    }
}
