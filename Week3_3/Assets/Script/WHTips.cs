using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WHTips : MonoBehaviour
{
    private CharacterController myCharacterController;
    public GameObject player;
    public GameObject fireDialog;
    public Text textFire;
    public Text textTake;
    public Text textLost;
    private int windowTip = 2;
    private int wcTip = 2;
    private int lieTip = 2;
    private int balconyTip = 1;
    private int seconds = 2;

    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
        //player = GetComponent<GameObject>();
        InvokeRepeating("timeTest", 2f, 1f);
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
            seconds = 2;
            //加个计时器
            textFire.text = "有灭火器，是否去灭火？";
            textTake.text = "灭火";
            textLost.text = "小朋友，火势太大，灭火是不对的，我们的任务是逃生，然后拨打119";
            fireDialog.SetActive(true);
        }
        else if (hitObject.transform.name.Equals("lift"))
        {
            seconds = 2;
            //加个计时器
            textFire.text = "有电梯，是否乘坐？";
            textTake.text = "乘坐";
            textLost.text = "小朋友，逃生期间乘坐是不对的，";
            fireDialog.SetActive(true);
        }

    }

    public void timeTest()
    {
        seconds--;
        if (seconds < 0)
        {
            fireDialog.SetActive(false);
        }
    }
}
