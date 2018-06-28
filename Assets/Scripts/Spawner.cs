using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] attackersPrefabArray;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject thisAttacker in attackersPrefabArray)
        {
            if (TimeToSpawn(thisAttacker)) Spawn(thisAttacker); 
        }
	}
    bool TimeToSpawn(GameObject attacker)
    {
        Attacker myAttacker = attacker.GetComponent<Attacker>();

        float spawnDelay = myAttacker.seenEverySeconds;
        float spawnsPerSeconds = 1 / spawnDelay;
        float hold = Time.deltaTime * spawnsPerSeconds/5;
        return (Random.value < hold);
    }
    void Spawn (GameObject attacker)
    {
        GameObject myAttacker = Instantiate(attacker) as GameObject;
        myAttacker.transform.parent = transform;
        myAttacker.transform.position = transform.position;
    }
}
