using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCheker : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector3 postrans = Camera.main.WorldToViewportPoint(transform.position);
        if (postrans.x < -0.5 || postrans.x > 1.5 || postrans.y < -0.5 || postrans.y > 1.5)
            Destroy(gameObject);
    }
}
