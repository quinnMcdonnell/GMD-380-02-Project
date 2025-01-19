using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] private float health;

    public void TakeDamage(float damage)
    {
        health -= damage;

        if(health <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
