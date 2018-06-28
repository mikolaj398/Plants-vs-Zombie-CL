using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour {

    private Slider slider;
	public float levelSeconds =5f;
	private bool levelEnded;
	private AudioSource audio;
	private LevelManager levelManager;
	private GameObject winLabel;
    void Start () {

		audio = GetComponent<AudioSource> ();
		levelEnded = GameObject.FindObjectOfType<LevelManager> ();
		winLabel = GameObject.Find ("WinLabel");
		winLabel.SetActive (false);
		if (!winLabel)
			Debug.Log ("No Win Label");
        slider = GetComponent<Slider>();
		levelEnded = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		slider.value = Time.timeSinceLevelLoad / levelSeconds;
		bool isTimeUp = (Time.timeSinceLevelLoad >= levelSeconds);
		//Debug.Log (Time.timeSinceLevelLoad);
		//Debug.Log("time up "+ isTimeUp);
		//Debug.Log("level "+ levelEnded);
		if (isTimeUp && !levelEnded) 
		{
			Debug.Log ("fdgdbv");
			audio.Play ();
			Invoke ("LoadNextLevel", audio.clip.length);
			levelEnded = true;
			winLabel.SetActive (true);
		}
	}
	void LoadNextLevel()
	{
		levelManager.LoadNextLevel ();
	}

}
