using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : MonoBehaviour
{
    public float speed;
    public LayerMask enemyLayer;
    private PlayerController playerController;
    private Vector2 direction;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    public float stopDistance;
    public float retreatDistance;
    private Transform target;
    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, target.position) > stopDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, target.position) < stopDistance && Vector2.Distance(transform.position, target.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position, target.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }
    }
     void Attack()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<PlayerController>()?.TakeDamage(damage);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerController.TakeDamage(damage);
        }
    }
}
