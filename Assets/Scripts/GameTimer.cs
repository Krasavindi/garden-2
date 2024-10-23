using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Our level timer in seconds")]
    [SerializeField] float levelTime = 10;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        
    }
    public bool TimeIsFinished()
    {
        if(Time.timeSinceLevelLoad >= levelTime)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void IsOver()
    {
        if(TimeIsFinished())
        {
            Debug.Log("Time is over");
        }
        
    }

}
