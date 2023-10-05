using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKE_Attack : MonoBehaviour
{   
    public Transform attackPoint;
    public LayerMask playerLayer;
    private Animator animator;
    private Rigidbody2D rb2d;
    public float attackRange = 3f;
    public int attackDamage = 10;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    public void Attack()
    {
        Collider2D[] hitEnimies = Physics2D.OverlapCircleAll(attackPoint.position, 
        attackRange, playerLayer);
        foreach (Collider2D enemy in hitEnimies)
        {
            Debug.Log("we hit " + enemy.name);
            enemy.GetComponent<PlayerHealth>().TakeDamage(attackDamage);
        }
    }   
}
