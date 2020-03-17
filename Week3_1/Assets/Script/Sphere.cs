using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    //Camera camera;
    //public float moveSpeed = 2f;
    //public float rotateSpeed = 2f;

    //private void Start()
    //{
    //    GameObject gameObject = GameObject.Find("Main Camera");
    //    camera = gameObject.GetComponent<Camera>();
    //}
    //void Update()
    //{
    //    float h = Input.GetAxis("Horizontal");
    //    float v = Input.GetAxis("Vertical");
    //    if (h != 0 || v != 0)
    //    {
    //        Vector3 targetDirection = new Vector3(h, 0, v);
    //        float y = camera.transform.rotation.eulerAngles.y;
    //        targetDirection = Quaternion.Euler(0, y, 0) * targetDirection;

    //        transform.Translate(targetDirection * Time.deltaTime * moveSpeed, Space.World);
    //    }
    //    if (Input.GetKey(KeyCode.J))
    //    {
    //        transform.Rotate(-Vector3.up * Time.deltaTime * rotateSpeed);
    //    }
    //}

    private Rigidbody rb;
    public GameObject player;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //player = GetComponent<GameObject>();
    }

    void FixedUpdate()
    {
        float horiInput = Input.GetAxis("Horizontal");
        float vertiInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horiInput, 0, vertiInput);

        rb.AddForce(movement * (speed));

    }
    private void OnCollisionStay(Collision collision)
    {
        //collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        player.layer = collision.gameObject.layer;
    }
}
