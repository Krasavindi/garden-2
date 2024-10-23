using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherColider) 
   {
        GameObject otherObject = otherColider.gameObject;
        if (otherObject.GetComponent<Defender>())
        {
          otherColider.GetComponent<Health>().damageDealer(10);
          
          Destroy(gameObject);

        }
        

        
       
   }
}
