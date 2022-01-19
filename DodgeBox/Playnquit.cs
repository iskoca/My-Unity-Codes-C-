using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Playnquit : MonoBehaviour
{
    int i =0;
   public void Quit1()
    {
        Application.Quit();

    }
  public void Play1()
    {
        SceneManager.LoadScene("1");
    }
}
