using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefsController.SetMasterVolume(0.4f);
        Debug.Log($"Volume is {PlayerPrefsController.GetMasterVolume()}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
