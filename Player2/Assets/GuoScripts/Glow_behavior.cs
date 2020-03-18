using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow_behavior : UnityEngine.MonoBehaviour
{ 
    private float stationaryTime;
    public bool HasBeenShot;
    public bool HasShouted;
    //public AudioClip colsound;
   // public AudioClip flysound;
    //private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        HasBeenShot = false;
        HasShouted = false;
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HasBeenShot && !HasShouted)
        {
            HasShouted = true;
            //audioSource.Stop();
           // audioSource.clip = flysound;
            //audioSource.Play();
        }

        if (HasBeenShot && GetComponent<Rigidbody>().velocity.magnitude < 0.2f)
        {
            // 更新时间
            if ((Time.time - stationaryTime) > 1.0f)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            stationaryTime = Time.time;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //audioSource.Stop();
       // audioSource.clip = colsound;
        //audioSource.Play();
    }

    public   void followExtinguisher(Vector3 v3)
    {
        GameObject obj=GameObject.Find("Glow_extinguish");
        if (obj != null)
        {
            Debug.Log(obj.name + " is obtained");
        }
        obj.GetComponent<Transform>().position = v3;
        Debug.Log(obj.name + "location is changed to "+ obj.GetComponent<Transform>().position);
    }

    //public static void  show()
    //{
    //    GameObject obj = GameObject.Find("Glow_extinguish");
    //    obj.SetActive(true);
    //}

    //public static void disappear()
    //{
    //    GameObject obj = GameObject.Find("Glow_extinguish");
    //    obj.SetActive(false);
    //}

    
}
