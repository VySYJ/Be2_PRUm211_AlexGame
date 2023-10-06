using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public HealthBar healthBarEnemy; //healthBar
    public Animator animator;
    public int maxHealth = 100;
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

        animator.SetBool("Death", true);

        mobCollider.enabled = true;
        mobFlip.enabled = false;
        this.enabled = false;
    }

}
