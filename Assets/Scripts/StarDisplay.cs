using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour {

    private int stars = 1000;
    private Text starsText; 
    private void Start()
    {
        starsText = GetComponent<Text>();
        DisplayStars();
    }
    public void AddStars (int amount)
    {
        stars += amount;
        DisplayStars();
    }
    public bool RemoveStars(int amount)
    {
        if (stars>=amount)
        {
            stars -= amount;
            DisplayStars();
            return true;
        }
        return false;
        
    }
    void DisplayStars()
    {
        starsText.text = stars.ToString();
    }
}
