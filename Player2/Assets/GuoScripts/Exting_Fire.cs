using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//与灭火器的烟碰撞，火焰消失
public class Exting_Fire : UnityEngine.MonoBehaviour
{
    // Start is called before the first frame update
    public float timeCout;//disappear time
    void Start()
    {
        //GameObject fire = GameObject.Find("Fire");
        //GameObject smokeLit = GameObject.Find("SmokeLit");
        //GameObject flares = GameObject.Find("Flares");
        //Physics.IgnoreCollision(this.GetComponent<Collider>(), fire.GetComponent<Collider>(),true);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.name + "  contact to the fire");
        if(other.tag=="Shot")
        {
            Debug.Log("the steam of the extinguisher is collided");
            //destroy the fire: include the fire flames smokedark smokelit sparksfallings sparksrising firelight
             Transform tr=this.gameObject.GetComponent<Transform>().parent;
            //firstly, destroy the fire and leave the smokelit
            foreach(Transform child in tr)
            {
              if(child.name!="SmokeLit")
                {
                    Destroy(child.gameObject);
                }
              else
                {
                    //destroy the smokelit after some times
                    //child.gameObject.particleSystem.startLifetime = 10;
                    StartCoroutine(ChangeFormTime(timeCout,child.gameObject));
                }
            }
            Debug.Log("destroy the fire contacted");
        }
    }

    IEnumerator ChangeFormTime(float timeCout,GameObject obj)
    {
        while (timeCout > 0)
        {            //倒计时            
            timeCout -= Time.deltaTime;
            if (obj.GetComponent<Renderer>().material.color.a > 0)
            {
                obj.gameObject.GetComponent<Renderer>().material.color = new Color(                   
                obj.GetComponent<Renderer>().material.color.r,
                 obj.GetComponent<Renderer>().material.color.g,
                 obj.GetComponent<Renderer>().material.color.b,
                   //会根据你输入的时间进行渐变                   
                 obj.GetComponent<Renderer>().material.color.a - Time.deltaTime / timeCout);
                yield return null;
            }
        }       
       obj.gameObject.SetActive(false);
        Destroy(obj);
    }
}
