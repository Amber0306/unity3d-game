using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    public Slider soundSlider;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //soundSlider = GameObject.Find("soundSetting").GetComponent<Slider>();
        //audioSource = GetComponent<AudioSource>();
        if (!PlayerPrefs.HasKey("soundValue"))
        {
            PlayerPrefs.SetFloat("soundValue", soundSlider.value);
        }
        soundSlider.value = PlayerPrefs.GetFloat("soundValue");
    }

    // Update is called once per frame
    void Update()
    {

        audioSource.volume = PlayerPrefs.GetFloat("soundValue");
        PlayerPrefs.SetFloat("soundValue", soundSlider.value);

    }

}
