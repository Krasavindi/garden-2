using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    float currentSpeed = 1f;
    GameObject currentTarget;
    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if(!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }
    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;
    }
    
    
    
    public void StrikeCurrentTarget(float damage)
    {
        if(!currentTarget) { return; }
        Health health = currentTarget.GetComponent<Health>();
        if(health)
        {
            health.damageDealer(damage);
        }
    }
    
}
