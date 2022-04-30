using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("PlayerStats")]
    public float speed;
    public float jumpHeight;
    private bool isGrounded;
    private Rigidbody2D rb;
    private float moveVelocity;
    [Header("PlayerHealth")]
    public int curHP;
    public int maxHP;

    [Header("GroundCheck")]
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    public int redKey;
    public int blueKey;
    
    public int greenKey;
    public int silverKey;
    public int goldKey;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
        curHP = maxHP;

    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if(Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
                
        moveVelocity = 0f;

        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        rb.velocity = new Vector2(moveVelocity,rb.velocity.y);
    }
    
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x,jumpHeight);
        
    }
     public void TakeDamage(int damage)
    {
        curHP -= damage;
       

        if(curHP <= 0)
            Die();

    }
    void Die()
    {
        Destroy(gameObject);
        Debug.Log("You have died.");
    }
}
