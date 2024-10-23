using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine (GoToStart());

    }
    IEnumerator GoToStart()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Start Screen");
    }
}
