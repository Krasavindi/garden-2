using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherColider) 
   {
        GameObject otherObject = otherColider.gameObject;
        if (otherObject.GetComponent<GraveStone>())
        {
             GetComponent<Animator>().SetTrigger("jumpTrigger");

        }
        
        else if (otherObject.GetComponent<Defender>())
        {
            GetComponent<NewBehaviourScript>().Attack(otherObject);
        }
        
       
   }
}
