using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour
{
    private bool Clicked;//是否点击
    public bool isHaveSteam;//与Clicked对应
    public GameObject ammo_glow;//预设
        //=GameObject.Find("Glow_extingsuish");;//灭火器发出烟
    private GameObject shot;//实例化烟的预设（相当于子弹）
    private Vector3 lastKnownPosition;//当前灭火器的位置
    private Vector3 nowPosition;

     //射线方法检测
    //Ray ray;
    //RaycastHit hit;
    //GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        lastKnownPosition = this.gameObject.GetComponent<Transform>().position;
        //ammo_glow = GameObject.Find("Glow_extinguish");//获取烟
        //发出烟
        //shot = Instantiate(ammo_glow, transform.position, Quaternion.identity) as GameObject;
        //Physics.IgnoreCollision(shot.collider, GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        //bool bIsButtonDown = Input.GetButton("Fire1");
        //if (!Clicked)
        //{
        //    if (bIsButtonDown)
        //    {
        //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //        RaycastHit rch;
        //        if (GetComponent<Collider>().Raycast(ray, out rch, 1000.0f))
        //        {
        //            Clicked = true;
        //            // 创建弹药
        //            if (null != shot)
        //            {
        //                shot.tag = "LastShot";
        //            }
        //            shot = Instantiate(ammo_glow, transform.position, Quaternion.identity) as GameObject;
        //            Physics.IgnoreCollision(shot.GetComponent<Collider>(), GetComponent<Collider>());
        //            shot.GetComponent<Rigidbody>().isKinematic = true;
        //        }
        //        else if (null != shot) // 发射
        //        {
        //            // 清空
        //            shot.tag = "LastShot";
        //            shot = null;
        //        }
        //    }
        //}
        //else if (bIsButtonDown)//拉动弹弓
        //{
        //    Vector3 cameraWorldZ = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        //    lastKnownPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
        //                                                                   -cameraWorldZ.z));

        //    //计算打击方向
        //    Vector3 direction = transform.position - lastKnownPosition;
        //    direction.Normalize();
        //    float magnitude = Mathf.Min(Vector3.Distance(transform.position, lastKnownPosition), 2.0f);
        //    shot.transform.position = transform.position + direction * -magnitude;
        //}
        //else
        //{
        //    // 计算方向
        //    Vector3 direction = transform.position - lastKnownPosition;
        //    float magnitude = Mathf.Min(Vector3.Distance(transform.position, lastKnownPosition), 2.0f);
        //    shot.GetComponent<Rigidbody>().isKinematic = false;
        //    direction.Normalize();

        //    shot.transform.position = transform.position;
        //    shot.GetComponent<Rigidbody>().velocity = direction * 10.0f * magnitude;
        //    Clicked = false;
        //    shot.tag = "shot";
        //    shot.GetComponent<Glow_behavior>().HasBeenShot = true;


        }


    

    
    //控制灭火器的方向

    //如果持续点击，则开始发出灭火烟
    //发出灭火的烟时，将烟生成一端与灭火器顶端连接

    //如果灭火烟的方向有火焰，且火焰前无障碍物，则使火焰熄灭

    //火焰特效消失，转换为熄灭的烟特效

    //如果火焰与角色发生碰撞，则角色失败

    //public void OnClickExtinguisher(UnityEngine.EventSystems.BaseEventData data = null)
    //{
    //    Debug.Log("点击了" + transform.name);
    //    //点击对应事件
    //    Clicked = true;
    //    doSomething();
    //}
    //void doSomething()
    //{

    //}
    
    
     void OnMouseDown()
    {
        Clicked = true;
        Debug.Log("extinguisher is clicked");
        //发出烟
        //获取当前灭火器位置
        nowPosition = this.gameObject.GetComponent<Transform>().position;
        //ammo_glow = GameObject.Find("Glow_extingsuish");//获取烟
        //实例化一个烟
        Vector3 v3 = transform.position;
        v3.y = v3.y + 1.0f;
        shot = Instantiate(ammo_glow, v3, Quaternion.identity) as GameObject;
        //重设烟的位置
        shot.GetComponent<Transform>().position = nowPosition;
        //将烟设为灭火器的子物体
        shot.GetComponent<Transform>().transform.parent = this.gameObject.GetComponent<Transform>().transform;
        //shot.GetComponent<Glow_behavior>().followExtinguisher(nowPosition);
        //重新渲染显示烟
        //Glow_behavior.show();
        shot.SetActive(true);
        isHaveSteam = true;
    }

    private void OnMouseUp()
    {
        Clicked=false;
        //烟消失
        Debug.Log("detect the mouse up");
        //ammo_glow.SetActive(false);
        //Glow_behavior.disappear();
        shot.SetActive(false);
        Destroy(shot);
        isHaveSteam = false;
    }
}

