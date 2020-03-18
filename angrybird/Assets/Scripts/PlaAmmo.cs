using UnityEngine;
using System.Collections;

public class PlaAmmo : MonoBehaviour {

	private float stationaryTime;
	public bool HasBeenShot;
	public bool HasShouted;
	public AudioClip colsound;
	public AudioClip flysound;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		HasBeenShot = false;
		HasShouted = false;
		audioSource = GetComponent<AudioSource>();
	}
	// Update is called once per frame
	void Update () {
		if (HasBeenShot && !HasShouted)
		{
			HasShouted = true;
			audioSource.Stop();
			audioSource.clip = flysound;
			audioSource.Play();
		}

		if (HasBeenShot && GetComponent<Rigidbody>().velocity.magnitude < 0.2f)
		{
			// 更新时间
			if ((Time.time-stationaryTime) > 1.0f)
			{
				Destroy(gameObject);
			}
		}
		else
		{
			stationaryTime = Time.time;
		}
	}

	void OnCollisionEnter(Collision collision) {
		audioSource.Stop();
		audioSource.clip = colsound;
		audioSource.Play();
	}
}
