using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamerab : MonoBehaviour
{
    public Transform m_player; //角色的Transform
    public Vector3 Offset;  //摄像机与角色的相对位置偏移
    private float smoothing = 3; //移动平滑度
                                 // Use this for initialization
    void Start()
    {
        //得到角色和偏移
        //target = GameObject.FindWithTag("Player").transform;
        //Offset = new Vector3(-0.2173055f, 3.476311f, -3.444581f);
    }

    /// <summary>
    /// 这里使用LateUpdate可以减少镜头晃动
    /// </summary>
    void Update()
    {
        //target.TransformDirection(Offset) 将偏移从局部坐标变为世界坐标,达到摄像机永远在角色背后的目的
        transform.position = Vector3.Lerp(transform.position, m_player.position + m_player.TransformDirection(Offset), Time.deltaTime * smoothing);
        //摄像机朝向角色
        transform.LookAt(m_player);

        RaycastHit hit;
        if (Physics.Linecast(m_player.position + Vector3.up, transform.position, out hit))
        {
            string name = hit.collider.gameObject.tag;
            if (name != "MainCamera")
            {
                //如果射线碰撞的不是相机，那么就取得射线碰撞点到玩家的距离
                float currentDistance = Vector3.Distance(hit.point, m_player.position);
                //如果射线碰撞点小于玩家与相机本来的距离，就说明角色身后是有东西，为了避免穿墙，就把相机拉近
                if (Mathf.Abs(currentDistance) < Offset.x|| Mathf.Abs(currentDistance) < Offset.y|| Mathf.Abs(currentDistance) < Offset.z)
                {
                    transform.position = hit.point;
                }
            }
        }
    }
}
