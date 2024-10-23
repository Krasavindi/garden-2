using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 15f;
    [SerializeField] int damage = 100;
    
    void Update()
    {
        
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        var health = other.GetComponent<Health>();
        var attacker = other.GetComponent<NewBehaviourScript>();
        
        if(attacker && health)
        {
            health.damageDealer(damage); 
            Destroy(gameObject); 
        }

          
    }
}
