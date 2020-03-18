using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Xml;
using UnityEngine.SceneManagement;
using System;

public class Login : MonoBehaviour
{
    
    public InputField username;
    public InputField password;
    public Text mistake;
    XmlDocument xdoc = null;
   


    // Start is called before the first frame update

    public void Onloginbutton( )
    {
        xdoc = new XmlDocument();
        xdoc.Load(Application.dataPath + "/dinos.xml");
        XmlElement root = xdoc.DocumentElement;
        XmlNode datanode = root.SelectSingleNode("dinos");

        for (int i = 0; i < datanode.ChildNodes.Count - 1; i++) {
            string id = datanode.ChildNodes[i].InnerText;
            string a = datanode.ChildNodes[i + 1].InnerText;
            int pw = int.Parse(a);
            string b = password.text;
            int c = int.Parse(b);
            if (pw== c && id == username.text)
            {

                SceneManager.LoadScene(2);
            }
            else
            {
               
                mistake.gameObject.SetActive(true);
                StartCoroutine(Disapper());
            }
        }
        IEnumerator Disapper()
        {
            yield return new WaitForSeconds(2);
            mistake.gameObject.SetActive(false);
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
