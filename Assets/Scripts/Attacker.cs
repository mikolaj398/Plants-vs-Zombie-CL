using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

    public float seenEverySeconds;
    private float currentSpeed;
    private GameObject currentTarget;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update () {
        transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
        if (!currentTarget) anim.SetBool("isAttacking", false);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  Debug.Log(name + "trigger enter");
    }
    public void SetSpeed (float speed)
    {
        currentSpeed = speed;
    }

    public void StrikeCurrnetObject (float damage)
    {
        if (currentTarget)
        {
            Health health = currentTarget.GetComponent<Health>();
            if (health)
            {
                
                health.DealDamage(damage);
            }
        }
    }
    public void Attack(GameObject obj)
    {
        currentTarget = obj;
    }
}
