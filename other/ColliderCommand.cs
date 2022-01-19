using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColliderCommand : MonoBehaviour
{
    public GameObject ins;
    void OnCollisionEnter2D(Collision2D _colInfo)
    {
        if (_colInfo.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene("son");

        }
    }
}
