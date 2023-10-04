using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 200;
    public int health;
    void Start()
    {
        health = maxHealth;
    }
    public void TakeDamage(int dmg){
        health -= dmg;
        animator.SetTrigger("Hurt");
        if(health<=0){
            Dead();
        }
    }
    public void Dead(){
        Debug.Log("Player die");
        animator.SetBool("IsDeath", true);
        GetComponent<Collider2D>().enabled = false;
        //this.enabled = false;
    }
}
