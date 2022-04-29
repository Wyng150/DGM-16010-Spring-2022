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

    [Header("GroundCheck")]
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();

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
}
