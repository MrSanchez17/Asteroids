using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OvniSpawner : MonoBehaviour
{
    public GameObject OvniPrefab;
    private float time;
    public bool active;

    void Start()
    {
        time = 0;
        active = true;
    }

    void Update()
    {
        if(time>15)
        {
            GameObject Ovnip = Instantiate(OvniPrefab, transform.position, Quaternion.identity);
            time = 0;
        }
        else
        {
            time += Time.deltaTime;
        }
    }

    /*public void StopSpawner()
    {
        active = false;
        

    }

    public void StartSpawner()
    {
        active = true;
    }*/
}