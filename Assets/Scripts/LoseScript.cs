using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScript : MonoBehaviour {

    private LevelManager levelManager;

	void Start () {
        levelManager = GameObject.FindObjectOfType<LevelManager>();	
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (levelManager==null) Debug.Log("dupa");
        levelManager.LoadLevel("Loose");
    }


}
