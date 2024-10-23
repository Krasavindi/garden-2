using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] float baseHealth = 150;
    float health;
    TextMeshProUGUI healthText;
    goToStart level;
    
    
    
    void Start()
    {
        
        health = baseHealth - PlayerPrefsController.GetMasterDifficulty() * 50;
        

        
        level = FindObjectOfType<goToStart>();
        healthText = GetComponent<TextMeshProUGUI>();
        
        UpdateDisplay();
        
    }
    private void UpdateDisplay()
    {
        
        healthText.text = health.ToString();
        
    }

    public void DecreaseHealth(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            StartCoroutine(loseLevel());
            health = 0;
        }
       UpdateDisplay();
    }
    IEnumerator loseLevel()
    {
        FindObjectOfType<LevelController>().SetLoseLable();

        yield return new WaitForSeconds(5);
        FindObjectOfType<goToStart>().GameOver();
    }
    public float GetHealth()
    {
        return health;
    }

    

    
}
