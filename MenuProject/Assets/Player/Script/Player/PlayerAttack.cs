using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform attackPoint;
    public LayerMask enemyLayers;
    private Animator animator;
    private Rigidbody2D rb2d;
    public float attackRange = 0.5f;
    public int attackDamage = 10;
    // public int maxPlayerHealth = 150;
    // int currentPlayerHealth;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        // currentPlayerHealth = maxPlayerHealth;
    }

    void Update()
    {

    }
    public void Attack()
    {
        animator.SetBool("IsAttack", true);
        Collider2D[] hitEnimies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider2D enemy in hitEnimies)
        {
            Debug.Log("we hit " + enemy.name);
            enemy.GetComponent<EnemyHealth>().TakeDamage(attackDamage);
        }
    }
}
