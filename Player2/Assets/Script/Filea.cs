using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Filea : UnityEngine.MonoBehaviour
{
    public GameObject dialog;
    public Text btnText;
    public Text tipText;
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
            dialog.SetActive(true);
            btnText.text = "乘坐";
            tipText.text = "乘坐电梯需谨慎，由于电梯故障，您逃生失败";
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dialog.SetActive(false);
        }
    }
}
