using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraField : MonoBehaviour
{
    Camera camera;
    public int[] fieldlevel;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        camera = this.GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        camerafield();

    }

    void camerafield()
    {
        if (Input.GetMouseButtonDown(1))
        {
            index = index < fieldlevel.Length - 1 ? index + 1 : 0;
        }
        camera.fieldOfView = Mathf.Lerp(camera.fieldOfView, fieldlevel[index], 0.1f);
        if (Mathf.Abs(camera.fieldOfView - fieldlevel[index]) < 0.1f)
        {
            camera.fieldOfView = fieldlevel[index];
        }

    }
}
