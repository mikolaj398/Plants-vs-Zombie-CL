using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour {

    public Camera myCamera;
    private GameObject parent;
    private StarDisplay starDisplay;
    private void Start()
    {
        starDisplay = GameObject.FindObjectOfType<StarDisplay>();
        parent = GameObject.Find("Defenders");
        if (!parent)
        {
            parent = new GameObject("Defenders");
        }
    }
    private void OnMouseDown()
    {
        Debug.Log(Input.mousePosition);
        Debug.Log("aaaa "+ RoundWorldPoints(CalculateWorldPointOfMouseClick()));
        int defenderCost = Button.selectedDefender.GetComponent<Defenders>().defendeerCost;
        if (starDisplay.RemoveStars(defenderCost))

        {
            GameObject def = Instantiate(Button.selectedDefender, RoundWorldPoints(CalculateWorldPointOfMouseClick()), Quaternion.identity) as GameObject;
            def.transform.parent = parent.transform;
        }
    }
    Vector2 RoundWorldPoints (Vector2 rawCoordinates)
    {
        float minX = Mathf.RoundToInt(rawCoordinates.x);
        float minY= Mathf.RoundToInt(rawCoordinates.y);

        return new Vector2(minX, minY);
    }
    Vector2 CalculateWorldPointOfMouseClick()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        Vector3 helpVector = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(helpVector);

        return worldPos;
    }
}
