using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;
    [HideInInspector]
    public float speed;

    public float Health = 100;

    public int value = 50;

    public GameObject deathEffect;

    void Start()
    {
        speed = startSpeed;
    }

    
    public void TakeDamage(float amount)
    {
        Health -= amount;
        if(Health <= 0)
        {
            Die();
        }
    }
    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }
    void Die()
    {
        PlayerStats.Money += value;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);
        Destroy(gameObject);
    }
    
}
