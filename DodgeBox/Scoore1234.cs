using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoore1234 : MonoBehaviour
{
    int skor;
    public Text hs;
    // Start is called before the first frame update
    void Start()
    {
        skor = PlayerPrefs.GetInt("HighScore");
        hs.text = "" + skor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
