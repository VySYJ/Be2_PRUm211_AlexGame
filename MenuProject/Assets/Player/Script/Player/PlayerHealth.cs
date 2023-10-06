using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public HealthBar healthBarPlayer; //healthBar
    public Animator animator;
    public int maxHealth = 200;
    public int health;
    bool isdead = false;
    void Start()
    {
        health = maxHealth;
        healthBarPlayer.SetMaxHealth(maxHealth); //healthBar
    }
    public void TakeDamage(int dmg)
    {
        Debug.Log("Player Hurt");
        health -= dmg;

        AudioManager.instance.PlaySound(AudioManager.instance.hurt, 1f);

        animator.SetTrigger("Hurt");
        animator.SetBool("IsDeath", false);
        isdead = false;

        healthBarPlayer.SetHealth(health); //healthBar
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

        AudioManager.instance.PlaySound(AudioManager.instance.dead, 1f);

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


    //healthBar
    public void IncreaseHealth(int amount)
    {
        health += amount;
        health = Mathf.Clamp(health, 0, maxHealth);
        healthBarPlayer.SetHealth(health);
    }
}