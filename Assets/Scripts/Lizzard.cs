using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lizzard : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D otherColider) 
   {
        GameObject otherObject = otherColider.gameObject;
        if (otherObject.GetComponent<Defender>())
        {
            GetComponent<NewBehaviourScript>().Attack(otherObject);
        }
       
   }
}
