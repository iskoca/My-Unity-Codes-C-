using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Camera2DFollow : MonoBehaviour
    {
        public Transform target;
        public float speed = 1.0f;

        void LateUpdate()
        {
            Vector3 v3 = transform.position;
            v3.y = Mathf.Lerp(v3.y, target.position.y+3.8f, Time.deltaTime * speed);
            transform.position = v3;
        }
    }
}
