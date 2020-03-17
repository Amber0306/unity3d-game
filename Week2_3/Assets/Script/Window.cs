using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    private Animator animator;
    private bool isopen = true;
    private bool isTip = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (isopen)
            {
                animator.Play("windowopen");
                isopen = !isopen;

            }
            else
            {
                animator.Play("windowclose");
                isopen = !isopen;
            }
            if (isTip)
            {
                GameObject.Find("Tip").GetComponent<ShowTip>().show("跳吧跳吧，能活着算我输，你个弟弟！！！");
                isTip = false;
            }
        }
    }
}
