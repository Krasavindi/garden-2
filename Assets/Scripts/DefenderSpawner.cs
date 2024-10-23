using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Device;

public class DefenderSpawner : MonoBehaviour
{
    Defender defenderPrefab;
    GameObject defenderParent;
    const string DEFENDER_PARENT_NAME = "Defenders";
   private void Start() 
    {
        
        CreateDefenderParent();   
    }
    
    private void CreateDefenderParent()
    {
        defenderParent = GameObject.Find(DEFENDER_PARENT_NAME);
        if(!defenderParent)
        {
            defenderParent = new GameObject(DEFENDER_PARENT_NAME);
        }
    }

    private void OnMouseDown() 
    {
        
        AttemptToPlaceDefenderAt(GetSquareClicked());
        
    }
    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defenderPrefab = defenderToSelect;
    }
    private void AttemptToPlaceDefenderAt(UnityEngine.Vector2 gridPos)
    {
        var StarDisplay = FindObjectOfType<StarDisplay>();
        int defenderCost = defenderPrefab.GetStarCost();
        
        if (StarDisplay.HaveEnoughStars(defenderCost))
        {
            SpawnDefender(gridPos);
            StarDisplay.SpendStars(defenderCost);
            
        }
           
    }

    private UnityEngine.Vector2 GetSquareClicked()
    {
        UnityEngine.Vector2 clickPos = new UnityEngine.Vector2 (Input.mousePosition.x, Input.mousePosition.y);
        UnityEngine.Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        UnityEngine.Vector2 gridPos = SnapTOGrid(worldPos);
        return gridPos;
    }
    private UnityEngine.Vector2 SnapTOGrid(UnityEngine.Vector2 rawDefenderPos)
    {
        float newX = Mathf.RoundToInt(rawDefenderPos.x);
        float newY = Mathf.RoundToInt(rawDefenderPos.y);
        return new UnityEngine.Vector2(newX, newY);
    }

    private void SpawnDefender(UnityEngine.Vector2 defenderPos)
    {
        Defender newDefender = Instantiate(defenderPrefab, defenderPos, UnityEngine.Quaternion.identity) as Defender;
        newDefender.transform.parent = defenderParent.transform;
    }
}
