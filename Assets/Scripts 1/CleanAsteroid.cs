using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanAsteroid : MonoBehaviour
{
    // Start is called before the first frame update
    public void CleanGame()
    {
        Transform[] listarasteoids = GetComponentsInChildren<Transform>();
        for( int i = 1; i<listarasteoids.Length; i++)
            Destroy(listarasteoids[i].gameObject);
    }

    public void CleanGame2()
    {
        GameObject[] listarasteoids = GameObject.FindGameObjectsWithTag("Asteroids");
        for( int i = 0; i<listarasteoids.Length; i++)
            Destroy(listarasteoids[i].gameObject);
    }
}
