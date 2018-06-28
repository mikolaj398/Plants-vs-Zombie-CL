using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Button : MonoBehaviour {

    public GameObject defenderPrefab;
    private Button[] buttonAray;
    public static GameObject selectedDefender;
	private Text costText;
	void Start () {
        buttonAray = GameObject.FindObjectsOfType<Button>();
		costText = GetComponentInChildren<Text> ();
		costText.text = defenderPrefab.GetComponent<Defenders> ().defendeerCost.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        
        foreach(Button thisButton in buttonAray)
        {
            thisButton.GetComponent<SpriteRenderer>().color = Color.black;
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        selectedDefender = defenderPrefab;
        Debug.Log(selectedDefender);
    }

}
