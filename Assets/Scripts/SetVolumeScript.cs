using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVolumeScript : MonoBehaviour {

    private MusicManager musicManager;
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        if (musicManager)
        {
            float volume = PlayerPrefManager.GetMasterVolume();
            musicManager.SetVolume(volume);
        }
        else Debug.LogWarning("MusicManager not found");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
