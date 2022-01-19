using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

     public Transform[] values;
     public  GameObject gm;


    // Start is called before the first frame update
    void Awake()
    {

        StartCoroutine(qwendy());


    }

    // Update is called once per frame
    void FixedUpdate()
    {
    }
    IEnumerator qwendy()
    {
 
        float zaman = 2.5f;
        do
        {
            int a;
            a = Random.RandomRange(0, 5);
            for (int i = 0; i < 5; i++)
            {
                if (a == i) {  }
                else
                {
                    Instantiate(gm, values[i]);
                    
                }
            }
            if (zaman > 1.5) {
            zaman = zaman - 0.1f;
                Debug.Log(zaman);
            }
            yield return new WaitForSeconds(zaman);
        } while (true);
    }
}
