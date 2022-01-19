using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public GameObject player;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.up * 3 * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -7 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * 7 * Time.deltaTime;
        }
        if(player.transform.position.x <= -10 || player.transform.position.x >= 10)
        {

            SceneManager.LoadScene("son");
        }
    }
}
