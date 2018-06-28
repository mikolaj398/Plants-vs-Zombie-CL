using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Attacker))]
public class Fox : MonoBehaviour {

    private Animator anim;
    private Attacker attack;
	void Start () {

        anim = GetComponent<Animator>();
        attack = GetComponent<Attacker>();
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (!obj.GetComponent<Defenders>()) return;
        if (obj.GetComponent<GraveStone>())
        {
            anim.SetTrigger("jump");
        }
        else
        {
            anim.SetBool("isAttacking", true);
            attack.Attack(obj);
        }
    }

    void Update () {
		
	}
}
