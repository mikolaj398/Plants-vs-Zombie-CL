using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject projectile, gun;
    private GameObject parentObject;
    private Animator anim;
    private Spawner myLaneSpawner;
    private void Start()
    {
        anim = GetComponent<Animator>();
        parentObject = GameObject.Find("Projectiles");
        if (!parentObject)
        {
            parentObject = new GameObject("Projectiles");
        }
        FindMyLaneSpawner();
    }
    private void Update()
    {
        //Debug.Log(IsAttackerAheadOfLine());
        if (IsAttackerAheadOfLine())
        {
            anim.SetBool("isAttacking", true);
        }
        else
        {
            anim.SetBool("isAttacking", false);
        }
    }
    void FindMyLaneSpawner()
    {
        Spawner[] spawners = GameObject.FindObjectsOfType<Spawner>();
        foreach(Spawner spawner in spawners)
        {
            if (spawner.transform.position.y == transform.position.y)
            {
                myLaneSpawner = spawner;
                return;
            }
        }
    }
    bool IsAttackerAheadOfLine()
    {
        if (myLaneSpawner.transform.childCount <= 0) return false;
        foreach(Transform attacker in myLaneSpawner.transform)
        {
            if (attacker.transform.position.x > transform.position.x) return true;
        }
        return false;
    }
    void Fire()

    {
        GameObject newProjectile = Instantiate(projectile) as GameObject;
        newProjectile.transform.parent = parentObject.transform;
        newProjectile.transform.position = gun.transform.position;
    }
}
