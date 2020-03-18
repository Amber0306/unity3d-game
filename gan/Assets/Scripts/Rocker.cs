using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocker : MonoBehaviour
{
    Vector2 startPosition;
    Vector2 position;
    public GameObject rockerPoint;

    private void Start()
    {
        position = transform.position;
    }
    void Drag()
    {
        Vector2 temp = (Vector2)Input.mousePosition - startPosition;
        if(temp.magnitude >= 50)
        {
            temp = temp.normalized * 50;
        }
        rockerPoint.transform.position = startPosition + temp;
    }
    void DragBegin()
    {
        startPosition = Input.mousePosition;
        transform.position = startPosition;
    }
    void DragEnd()
    {
        transform.position = position;
        rockerPoint.transform.position = position;
    }
}
