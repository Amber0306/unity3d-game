using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accountchange : MonoBehaviour
{
    public string username;
    public string password;
    public InputField Usernameinput;
    public InputField Passwordinput;
    // Start is called before the first frame update
    void Start()
    {
        Usernameinput = GameObject.Find("Usernameinput").GetComponent<InputField>();
        Passwordinput= GameObject.Find("Passwordinput").GetComponent<InputField>();
    }
    void getstring()
    {
        username = Usernameinput.text;
        password = Passwordinput.text;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
