using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WHTips : MonoBehaviour
{
    private CharacterController myCharacterController;
    public GameObject player;
    public GameObject fireDialog;
    public Text textTake;
    public Text textLost;
    private int windowTip = 2;
    private int wcTip = 2;
    private int lieTip = 2;
    private int balconyTip = 1;

    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
        //player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        myCharacterController.Move(new Vector3(0, 0, 0));
        //Debug.Log("enter");
    }

    //角色控制器组件在与具有Collider组件对象之间的碰撞
    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //得到接收碰撞名称
        GameObject hitObject = hit.collider.gameObject;
        player.layer = hitObject.layer;

        if (windowTip>0&&hitObject.transform.name.Equals("wallWindowSlide"))
        {
            GameObject.Find("Tip").GetComponent<ShowTip>().show("窗户提示");
            windowTip--;
            //Debug.Log("111111111");
        }
        else if (wcTip > 0 && hitObject.transform.name.Equals("wcTip"))
        {
            GameObject.Find("Tip").GetComponent<ShowTip>().show("卫生间提示");
            wcTip--;
            //Debug.Log("111111111");
        }
        else if (balconyTip > 0 && hitObject.transform.name.Equals("balconyTip"))
        {
            GameObject.Find("Tip").GetComponent<ShowTip>().show("阳台提示");
            balconyTip--;
            //Debug.Log("111111111");
        }
        else if (lieTip > 0 && hitObject.transform.name.Equals("lieTip"))
        {
            GameObject.Find("Tip").GetComponent<ShowTip>().show("卧倒提示");
            lieTip--;
            //Debug.Log("111111111");
        }

        if (hitObject.transform.name.Equals("fireplug01_plug"))
        {
            //加个计时器

            textTake.text = "灭火";
            textLost.text = "灭火失败";
            fireDialog.SetActive(true);
        }
        else if (hitObject.transform.name.Equals("lift"))
        {
            //加个计时器

            textTake.text = "乘坐";
            textLost.text = "乘电梯失败";
            fireDialog.SetActive(true);
        }

    }
}
