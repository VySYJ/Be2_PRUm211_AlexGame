using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 200;
    public int health;
    bool isdead = false;
    void Start()
    {
        health = maxHealth;
    }
    public void TakeDamage(int dmg)
    {
        Debug.Log("Player Hurt");
        health -= dmg;
        animator.SetTrigger("Hurt");
        animator.SetBool("IsDeath", false);
        isdead = false;
        Deaded();
        if (health <= 0)
        {
            Dead();
        }
    }
    public void Dead()
    {
        Debug.Log("Player die");
        animator.SetBool("IsDeath", true);
        // PlayerMovement playerMovement = gameObject.GetComponent<PlayerMovement>();
        // GetComponent<Collider2D>().enabled = false;
        // playerMovement.enabled = false;
        this.enabled = false;
        isdead = true;
        Deaded();
    }
    public bool Deaded()
    {
        return isdead;
    }
}
