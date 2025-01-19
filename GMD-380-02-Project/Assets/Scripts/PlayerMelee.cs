using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMelee : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private float meleeSpeed;
    [SerializeField] private float damage;

    float timeUntilMelee;

    private void Update()
    {
        if(timeUntilMelee <= 0f)
        {
            if(InputManager.inputAction > 0f) //Change to use input System
            {
                anim.SetTrigger("Attack");
                timeUntilMelee = meleeSpeed;
            }
        } else
        {
            timeUntilMelee -= Time.deltaTime;
        }
    }

    private void onTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger");
        if(other.tag == "Enemy")
        {
            other.GetComponent<EnemyStats>().TakeDamage(damage);
            Debug.Log("hit");
        }
    }

    //Combat and enemy health: https://www.youtube.com/watch?v=giJKCl-GVrU
}
