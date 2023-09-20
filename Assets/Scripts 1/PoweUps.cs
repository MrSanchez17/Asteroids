using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoweUps : MonoBehaviour
{
    public float delay;
    public bool active;
    public int NumAsteroids;
    private float AsteroidsActual;
    public GameObject bombaPrefab;
    public GameObject Player;
    

    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        active = true;
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
                    GameObject bomb = Instantiate(bombaPrefab, transform.position, Quaternion.identity);
                    if (Player != null)
                        dir = Player.transform.position - bombaPrefab.transform.position;
                    else
                    {
                        dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
                    }
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
        time = 0;
    }
}
