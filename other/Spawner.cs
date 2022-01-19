using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject meteor;
    public Vector3 min, max;
    private Rigidbody2D rb2d;
    // Update is called once per frame

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = Random.Range(0.3f, 0.5f);
    }
    void Update()
    {
        if (meteor.transform.position.y < 6)
        {
            Vector3 myVector = new Vector3(UnityEngine.Random.Range(min.x, max.x), UnityEngine.Random.Range(min.y, max.y), UnityEngine.Random.Range(min.z, max.z));
            Instantiate(meteor, myVector, Quaternion.identity);
            Destroy(this.gameObject);
            
        }
        meteor.transform.Rotate(0, 0, Random.Range(0f, 7f));
    }
}
