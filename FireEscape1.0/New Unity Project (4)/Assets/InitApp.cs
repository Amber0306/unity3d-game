using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;

public class InitAPP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadXml();
    }
    public void LoadXml()
    {
        TextAsset textAsset = Resources.Load("xml/dinos") as TextAsset;
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(textAsset.text);
        XmlNodeList elemList = doc.GetElementsByTagName("dinos");
        foreach (XmlElement element in elemList) {
            Debug.Log("" + element.GetAttribute("password") + ":" + element.GetAttribute("username"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
