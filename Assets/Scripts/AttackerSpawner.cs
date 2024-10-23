using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minDelay = 1f;
    [SerializeField] float maxDelay = 5f;
    [SerializeField] GameObject[] attackerPrefabs;
    GameObject attackerPrefab;
    int index;
    bool spawn = true;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds (Random.Range(minDelay, maxDelay));
            if(!FindObjectOfType<GameTimer>().TimeIsFinished())
            {
                SpawnAttacker();
            }
            
        }
    }
    // public void StopSpawning()
    // {
    //     spawn = false;
    // }
    private void SpawnAttacker()
    {
        index = Random.Range(0, attackerPrefabs.Length);
        attackerPrefab = attackerPrefabs[index];
        GameObject newAttacker = Instantiate(attackerPrefab, transform.position, transform.rotation) as GameObject;
        newAttacker.transform.parent = transform;
    }
    

    // Update is called once per frame
    void Update()
    {
        
        
        
    }
    
}
