using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy Health")]
    public int curHp;
    public int maxHP;

    [Header ("Enemy attack")]
    public int damage;
    public float attackRate;
    public float attackRange;
    private float lastAttackTime;
    public PlayerController player;

    // Start is called before the first frame update
    public void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    public void Update()
    {
        if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange)
        {
            Attack();
        }
    }
    public void TakeDamage(int damage)
    {
        curHp -= damage;

        if(curHp <= 0)
            Die();

    }
    public void Attack()
    {
        lastAttackTime = Time.time;
        player.TakeDamage(damage);
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
