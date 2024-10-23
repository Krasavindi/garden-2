using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jabba : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D otherColider) 
   {
        GameObject otherObject = otherColider.gameObject;
        if (otherObject.GetComponent<Defender>())
        {
            Destroy(otherColider.gameObject);
        }
       
   }
}
