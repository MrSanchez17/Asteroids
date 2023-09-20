using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject Player;
    public GameObject AsteroidPrefab;
    public float delay;
    public bool active;
    public int NumAsteroids;
    private float AsteroidsActual;
    public GameObject Father;
    public GameObject Bomba;
    

    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        active = true;
        AsteroidsActual = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            if(AsteroidsActual<NumAsteroids)
            {
                Vector3 dir;
                time += Time.deltaTime;
                if (time > delay)
                {
                    GameObject asteroid = Instantiate(AsteroidPrefab, transform.position, Quaternion.identity);
                    asteroid.transform.parent = Father.transform;

                    if (Player != null)
                        dir = Player.transform.position - asteroid.transform.position;
                    else
                    {
                        dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
                    }
                    asteroid.GetComponent<Asteroid>().SetDirection(dir);
                    time = 0;
                }
            }
        }
    }

    public void StopSpawner()
    {
        active = false;
        

    }

    public void StartSpawner()
    {
        active = true;
        AsteroidsActual = 0;
    }

}
