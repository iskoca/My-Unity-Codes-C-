using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int scorevalue = 1;
    public Text textim;
    int hs;

    private void Start()
    {
        hs = PlayerPrefs.GetInt("HighScore");
    }
    // Update is called once per frame
    void Update()
        {
           textim.text = " " + scorevalue;
           deger();
        
    }

        void deger()
        {
        scorevalue++;
        if (scorevalue>hs) { 
        PlayerPrefs.SetInt("HighScore", scorevalue);

        hs = PlayerPrefs.GetInt("HighScore");
        }     
        }
    }
