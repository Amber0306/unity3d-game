using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//碰撞检测测试
public class CollideControl : UnityEngine.MonoBehaviour
{
    private Color originalColor; //物体原本的颜色
    private float deathTime; //物体的开始消失的时间 
    private float fadeSpeed;//物体消失的速度
    private float fadePercent;//物体消失的百分比
    public Material mat;  //获取物体的材质

    // Start is called before the first frame update
    void Start()
    {
        
        //mat = this.GetComponent< MeshRenderer>().material;//获取物体原本颜色
        //originalColor = mat.color;

      
        //StartCoroutine("Fade");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)   //检测函数,并将检测的结果放入other变量中.   
    {
        Debug.Log(other.name+" collide  ********************");
        if (other.name=="Role")    //将检测结果的碰撞对象与player对比.判断是否相等        
        {
           // this.GetComponent<Animation>().Play("Default Take");
            Debug.Log("Collide the  fire-----------");
            //other.GetComponent<>
            //this.gameObject.GetComponent<Renderer>().material.color =
            //    new Color(this.GetComponent<Renderer>().material.color.r, this.GetComponent<Renderer>().material.color.g, this.GetComponent<Renderer>().material.color.b,                    //会根据你输入的时间进行渐变                    this.GetComponent<Renderer>().material.color.a - Time.deltaTime / timeCout);


        }
    }
    private void OnTriggerExit(Collider other1)
    {
        if (other1.gameObject.tag == "player")
        {
            Debug.Log("exit the fire--------------");
        }
    }

    //IEnumerator Fade()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(.1f);//等待.1秒

    //        //开始消失
    //        if (fading)
    //        {
    //            //计算消失的比例
    //            fadePercent += Time.deltatime * fadeSpeed;
    //            //开始渐变
    //            mat.Color = Math.Lerp(originalColor, Color.clear, fadePercent);

    //            //当完全消失的时候，就应该销毁物体
    //            if (fadePercent >= 1)
    //            {
    //                Destory(gameObject);
    //            }
    //        }


    //        //如果到了消失时间,就开始消失
    //        if (Time.time > deathTime)
    //        {
    //            fading = true;
    //        }
    //    }
    //}


}


