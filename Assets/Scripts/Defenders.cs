using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defenders : MonoBehaviour {

    StarDisplay starDisplay;
    public int defendeerCost = 100;
    private void Start()
    {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
    }
    public void AddStars (int amount)
    {
        starDisplay.AddStars(amount);
    }
}
