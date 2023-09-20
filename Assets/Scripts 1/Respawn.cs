using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
 
    private Camera cam;
    private float camWidth;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        camWidth = cam.orthographicSize * 2f * cam.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica si el objeto se encuentra fuera de la cámara
        if (transform.position.x < cam.transform.position.x - camWidth / 2)
        {
            // Mueve el objeto al lado opuesto de la pantalla
            transform.position += new Vector3(camWidth, 0, 0);
        }
        else if (transform.position.x > cam.transform.position.x + camWidth / 2)
        {
            // Mueve el objeto al lado opuesto de la pantalla
            transform.position -= new Vector3(camWidth, 0, 0);
        }
    }
    
}
