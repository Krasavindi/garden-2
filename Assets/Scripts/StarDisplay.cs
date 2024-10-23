using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class StarDisplay : MonoBehaviour
{
    
    [SerializeField] float baseStars = 100;
    float stars;
    TextMeshProUGUI starText;
    
    void Start()
    {
        stars = baseStars - PlayerPrefsController.GetMasterDifficulty() * 40;
        starText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool HaveEnoughStars(int amount)
    {
        return stars >= amount;
    }
    
    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
    public void SpendStars(int amount)
    {
        if (stars > amount)
        {
            stars -= amount;
            UpdateDisplay();
        }
        else
        {
            stars = 0;
        }
        
    }
    public float GetStars()
    {
        return stars;
    }

    
}
