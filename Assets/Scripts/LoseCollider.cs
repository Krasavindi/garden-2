using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    [SerializeField] int damage;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "lizard")
        {
            damage = 10;
        }
        if(other.tag == "fox")
        {
            damage = 30;
        }
        if(other.tag == "jabba")
        {
            damage = 50;
        }
        if(other.tag == "crab")
        {
            damage = 5;
        }
        FindObjectOfType<HealthDisplay>().DecreaseHealth(damage);
    
        
        Destroy(other.gameObject);
    }
    
    
}
