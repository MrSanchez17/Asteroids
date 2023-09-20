using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    public GameObject bulletPrefab;
    private GameObject player;
    private float time;
    private Vector3 dir;
    public float delay;
    private Reload _bull;    

    void Start()
    {
        time= 0;
        player =  GameObject.FindObjectOfType<Player>().gameObject;
        _bull = GetComponent<Reload>();
    }

   public void Shoot(Vector3 dir, Vector3 position)
    {
        if(_bull.bullets>0)
        {
            GameObject bullet = Instantiate(bulletPrefab, position, Quaternion.identity);
            bullet.GetComponent<Bullet>().SetDirection(transform.right);
            _bull.ResetBullet(1);
        }
    }


    private void Update()
    {
        if(gameObject.layer == LayerMask.NameToLayer("Ovni"))
        {
            dir = player.transform.position - transform.position;
            time += Time.deltaTime;

            if(time>delay)
            {
                GameObject bulletOvni = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                bulletOvni.GetComponent<Bullet>().SetDirection(dir);
                time = 0;
            }
        }
    }
}
