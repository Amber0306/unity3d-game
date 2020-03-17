using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ww : MonoBehaviour
{
    public Transform m_player; //角色的Transform
    public Vector3 Offset;  //摄像机与角色的相对位置偏移
    public Vector3 OffAngle;
    // Start is called before the first frame update
    void Start()
    {
        Offset = transform.position - m_player.position;
        //OffAngle.x = transform.eulerAngles.x;
        //OffAngle.z = transform.eulerAngles.z;
        OffAngle = transform.eulerAngles - m_player.eulerAngles;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = m_player.position + Offset;
        transform.eulerAngles = m_player.eulerAngles + OffAngle;
    }
}
