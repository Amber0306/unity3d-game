using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCamera : MonoBehaviour
{
    public GameObject player;
    Camera mapCamera;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        mapCamera = GetComponent<Camera>();

        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        float y = player.transform.transform.position.y;
        if (0<y&&y<6)
        {
            player.layer = 11;
            mapCamera.cullingMask = 1 << 11;
        }
        else if(6 < y && y < 12)
        {
            player.layer = 12;
            mapCamera.cullingMask = 1 <<12;
        }
        else if (12 < y && y < 18)
        {
            player.layer = 13;
            mapCamera.cullingMask = 1 << 13;
        }
        else if (18 < y && y < 24)
        {
            player.layer = 14;
            mapCamera.cullingMask = 1 << 14;
        }
    }
}
