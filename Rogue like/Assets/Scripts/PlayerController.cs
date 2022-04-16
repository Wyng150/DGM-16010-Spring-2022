using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Health")]
    public int curHP;
    public int maxHP;
    public HealthBar healthBar;

    [Header("Pickups")]
    public int key;
    public int coins;
    public int gems;
  

    [Header("Player Movement")]
    public float moveSpeed = 5f; // Speed at which player moves
    private Rigidbody2D rb; // store referenced 2d rigid body
    private Vector2 movement;
    private Vector2 direction;

    [Header("Player Combat")]
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public int damage; //damage to enemy
    public LayerMask enemyLayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        curHP = maxHP;

        healthBar.SetHealth(maxHP);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); //left right movement
        movement.y = Input.GetAxis("Vertical"); //up down movement
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(Time.time -lastAttackTime >= attackRate)
            {
                Attack();
            }
        }
    }

    void FixedUpdate()
    {
        //apply physics and move the character
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();
    }
    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y);

        if(vel.magnitude != 0)
        {
            direction = vel;
        }
        rb.velocity = vel * moveSpeed;
    }
    void Attack()
    {
        lastAttackTime = Time.time;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }
    public void TakeDamage(int damage)
    {
        curHP -= damage;
        healthBar.SetHealth(curHP);

        if(curHP <= 0)
            Die();

    }
     void Die()
    {
        //Destroy(gameObject);
        Debug.Log("Player has been murdered");

    }
}
