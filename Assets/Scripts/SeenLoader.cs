using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SeenLoader : MonoBehaviour
{
    int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(currentSceneIndex);
        if(currentSceneIndex == 0)
        {
            StartCoroutine(Wait8Seconds());
           
        }
    }
    IEnumerator Wait8Seconds()
    {
        
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

}
