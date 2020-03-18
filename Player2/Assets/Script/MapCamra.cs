using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCamra : UnityEngine.MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset;
    void Start()
    {
        //camera = GetComponent<GameObject>();
        //offset.x = transform.position.x- player.transform.position.x;
        //offset.y = transform.position.y;
        //offset.z = transform.position.z;
        offset = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        offset.x = player.transform.position.x;
        transform.position = offset;
        
        GetComponent<Camera>().cullingMask = 1<<player.layer;
       // Debug.Log(player.layer);
    }
}
