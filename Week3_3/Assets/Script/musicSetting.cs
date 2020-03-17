using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicSetting : MonoBehaviour
{
      public Slider musicSlider;
     public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //musicSlider = GameObject.Find("musicSetting").GetComponent<Slider>();
        //audioSource = GetComponent<AudioSource>();
        if (!PlayerPrefs.HasKey("musicValue"))
        {
            PlayerPrefs.SetFloat("musicValue", musicSlider.value);
        }
        musicSlider.value = PlayerPrefs.GetFloat("musicValue");
    }

    // Update is called once per frame
    void Update()
    {

        audioSource.volume = PlayerPrefs.GetFloat("musicValue");
        PlayerPrefs.SetFloat("musicValue", musicSlider.value);

    }

}
