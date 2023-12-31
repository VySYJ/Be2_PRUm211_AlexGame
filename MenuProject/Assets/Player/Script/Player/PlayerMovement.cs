
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 9f;
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] public float attackDelay = 0.7f;

    private Vector2 vel;
    private Animator animator;
    private Rigidbody2D rb2d;

    private PlayerAttack playerAttack;
    private bool isJumpPressed;
    private bool isAttackPressed;
    private bool isAttacking = false;
    public bool isGrounded;
    public bool isJump;
    private float xAxis;

    const string PLAYER_IDLE = "Player_Idle";
    const string PLAYER_RUN = "Player_Run";
    const string PLAYER_JUMP = "Player_Jumping";
    const string PLAYER_Falling = "Player_Falling";
    const string PLAYER_ATTACK = "Player_Attack";
    const string PLAYER_HURT = "Player_Hurt";
    const string PLAYER_DEAD = "Player_Dead";

    public float attackRate = 1f;
    float nextAttackTime = 0f;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        playerAttack = GetComponent<PlayerAttack>();
        PlayTheme();
    }

    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(xAxis * walkSpeed, rb2d.velocity.y);
        isJumpPressed = Input.GetKeyDown(KeyCode.Space);
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isAttackPressed = true;
                stateAttack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }


        stateJump();
        // Debug.Log("Attack press: " + isAttackPressed);
        // Debug.Log("Is Attack: " + isAttacking);

        // Debug.Log("Chieu y la: " + rb2d.velocity.y);
        // Debug.Log("Chieu x la: " + xAxis);
        // Debug.Log("Ground la: " + isGrounded);

    }

    private void FixedUpdate()
    {
        stateFall();
        stateRun();
        stateIdle();
    }
    //check Ground
    void stateIdle()
    {
        if (isGrounded && rb2d.velocity.y == 0 && xAxis == 0)
        {
            animator.SetBool("IsFalling", false);
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsJumping", false);
        }
    }
    void stateRun()
    {
        if (!isJump && xAxis != 0)
        {
            AudioManager.instance.PlaySound(AudioManager.instance.run, 1f);
        }
        else
        {
            AudioManager.instance.StopSound(AudioManager.instance.run);
        }

        if (xAxis < 0 && isGrounded)
        {
            animator.SetBool("IsFalling", false);
            animator.SetBool("IsRunning", true);
            transform.localScale = new Vector2(-1, 1);
        }
        else if (xAxis > 0 && isGrounded)
        {
            animator.SetBool("IsFalling", false);
            animator.SetBool("IsRunning", true);
            transform.localScale = new Vector2(1, 1);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }

    }

    void stateJump()
    {
        if (isGrounded && isJumpPressed)
        {
            AudioManager.instance.PlaySound(AudioManager.instance.jump, 1f);

            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
            isJump = true;
            // Debug.Log("Chieu cao la: " + rb2d.velocity.y);
        }
    }

    void stateFall()
    {
        if (rb2d.velocity.y < 0 && !isGrounded)
        {
            animator.SetBool("IsJumping", false);
            animator.SetBool("IsFalling", true);
            isJump = false;
            StartCoroutine(DelayedFallSound(0.5f));
        }

    }


    void stateAttack()
    {

        if (isAttackPressed && isGrounded)
        {
            isAttackPressed = false;
            // Debug.Log("danh ne: " + isAttacking);
            AudioManager.instance.PlaySound(AudioManager.instance.attack, 1f);
            playerAttack.Attack();

        }
        Invoke("AttackComplete", attackDelay);
    }

    void AttackComplete()
    {
        animator.SetBool("IsAttack", false);
        isAttacking = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }

    }

    //check Ground
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }

    void PlayTheme()
    {
        AudioManager.instance.PlaySound(AudioManager.instance.theme, 0.3f, true);
        Debug.Log("loop theme");
        Invoke("PlayTheme", AudioManager.instance.theme.length);
    }

    //deplay sound fall
    IEnumerator DelayedFallSound(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (!isGrounded && rb2d.velocity.y < 0)
        {
            AudioManager.instance.PlaySound(AudioManager.instance.fall, 1f);
        }
    }
}
