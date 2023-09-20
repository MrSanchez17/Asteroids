using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovni : MonoBehaviour
{
    public float ovnipos;
    private bool ovnibool;
    public float speed;

    // Start is called before the first frame update
        void Start()
    {
        ovnipos = -8.0f;
        transform.position = new Vector3(-7, 4.0f, 0.0f);
        ovnibool = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 7)
        {
            ovnibool = false;
        }
        else if (transform.position.x < -8)
        {
           ovnibool = true;
        }
        if(ovnibool == false)
        {
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
    }
}


