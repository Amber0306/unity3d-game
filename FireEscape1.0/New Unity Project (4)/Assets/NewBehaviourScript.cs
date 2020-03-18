using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class NewBehaviourScript : MonoBehaviour
{
    XmlDocument xdoc = null;
    // Start is called before the first frame update
    void Start()
    {
        xdoc = new XmlDocument();
        xdoc.Load(Application.dataPath + "/dinos.xml");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
