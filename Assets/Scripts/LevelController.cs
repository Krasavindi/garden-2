using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;
    [SerializeField] GameObject winSound;
    [SerializeField] GameObject gameSound;
    [SerializeField] GameObject loseSound;
    
    

    bool setLoseLable = false;
    int attackers;
    
    
   
    void Start()
    {
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
        winSound.SetActive(false);
        loseSound.SetActive(false);
        gameSound.SetActive(true);
        
        
    }

    // Update is called once per frameS
    void Update()
    {
        attackers = FindObjectsOfType<NewBehaviourScript>().Count();
        TimeIsOver();
    }
    
    private void TimeIsOver()
    {
        
        if(FindObjectOfType<GameTimer>().TimeIsFinished())
        {     
            
            if(attackers == 0 && !setLoseLable)
                {
                    StartCoroutine(HandleWinCondition());
                }
            
        } 
    }
    
    IEnumerator HandleWinCondition()
        {
            
            winLabel.SetActive(true);
            winSound.SetActive(true);
            gameSound.SetActive(false);
           
            
            yield return new WaitForSeconds(3);
            FindObjectOfType<goToStart>().LoadNextScene();
           
        }

    public void SetLoseLable()
    {
        setLoseLable = true;
        loseLabel.SetActive(true);
        loseSound.SetActive(true);
        gameSound.SetActive(false);
        winLabel.SetActive(false);
        winSound.SetActive(false);
        Time.timeScale = 0;

    }

    
}
