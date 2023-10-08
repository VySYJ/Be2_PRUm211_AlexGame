using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public HealthBarMobs healthBarEnemy; //healthBar
    public Animator animator;
    public int maxHealth;
    int health;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBarEnemy.SetMaxHealth(maxHealth); //healthBar
    }
    public void TakeDamage(int damage)
    {
        if (health > 0)
        {
            Debug.Log("Boss bị thương");
            health -= damage;
            animator.SetTrigger("Hurt");

            AudioManager.instance.PlaySound(AudioManager.instance.mobRoar, 0.4f);

            healthBarEnemy.SetHealth(health); //healthBar

            if (health <= 0)
            {
                Death();
            }
        }
    }
    private void Death()
    {
        MobsCollider mobCollider = gameObject.GetComponent<MobsCollider>();
        MobFlip mobFlip = gameObject.GetComponent<MobFlip>();

        Debug.Log("Enemy die");
        AudioManager.instance.PlaySound(AudioManager.instance.mobDead, 1f);

        animator.SetBool("Death", true);

        mobCollider.enabled = true;
        mobFlip.enabled = false;
        this.enabled = false;
    }

}
