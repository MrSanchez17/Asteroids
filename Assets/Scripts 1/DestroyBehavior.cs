using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyBehavior : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject coinPrefab;


    public void DestroyObject()
    {


        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }


    public void DisableObject()
    {


        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }
        gameObject.SetActive(false);
    }

    public void SueltaMoneda()
    {
        if (coinPrefab != null)
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }
    }
}
