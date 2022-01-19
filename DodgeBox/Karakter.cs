using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;
public class Karakter : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1f;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D()
    {
       
        Time.timeScale = 0.1f;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
        StartCoroutine(LoadYourAsyncScene());
        
    }
    IEnumerator LoadYourAsyncScene()
    {

    yield return new WaitForSecondsRealtime(2);
        Time.fixedDeltaTime *= 10;
        SceneManager.LoadScene("0");
    }
}
