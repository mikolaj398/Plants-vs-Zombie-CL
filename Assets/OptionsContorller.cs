using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsContorller : MonoBehaviour {

    public Slider volumeSlider, diffficultySlider;
    public LevelManager levelManager;

    private MusicManager musicManager;
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        volumeSlider.value = PlayerPrefManager.GetMasterVolume();
        diffficultySlider.value = PlayerPrefManager.GetDifficulty();
    }
	
	// Update is called once per frame
	void Update () {
        musicManager.SetVolume(volumeSlider.value);
    }
    public void SaveAndExit()
    {
        PlayerPrefManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefManager.SetDifficulty(diffficultySlider.value);
        levelManager.LoadLevel("Start Menu");
    }
    public void SetDefaults()
    {
        volumeSlider.value = 0.8f;
        diffficultySlider.value = 2f;
    }
}
