using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();   
    }
    private void OnLevelWasLoaded(int level)
    {
        AudioClip musicThatWillBePlayed = levelMusicChangeArray[level];
        if (musicThatWillBePlayed)
        {
            audioSource.clip = musicThatWillBePlayed;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
    public void SetVolume (float volume)
    {
        audioSource.volume = volume;
    }
}
