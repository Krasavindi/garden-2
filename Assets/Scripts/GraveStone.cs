using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GraveStone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D otherCollider)
    {
        NewBehaviourScript attacker = otherCollider.GetComponent<NewBehaviourScript>(); 
        if (attacker)
        {

        }
    }
}
