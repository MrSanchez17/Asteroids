using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private NewControls nc;
    private MovementBehaviour mvb;
    public float speedRotation;
    public GameObject bulletPrefab;
    private ShootingBehavior _sht;
    public bool doubleShoot;
  
    private void Start()
    {
        nc = GetComponent<NewControls>();
        mvb = GetComponent<MovementBehaviour>();
        _sht = GetComponent<ShootingBehavior>();

    }

    void OnEnable()
    {
        Vector3 postrans = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.5f));
        postrans.z = 0;
        transform.position = postrans;
    }

    void Update()
    {
        transform.Rotate(0, 0, nc.moveValue.x * speedRotation);
        mvb.Move(nc.moveValue.y * transform.right);
    }

    public void Shooting()
    {
        if(!doubleShoot)
        {       
            _sht.Shoot(transform.right, transform.position);
        }
    }


}
