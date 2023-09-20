using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Reload : MonoBehaviour
{
    public UnityEvent<int> OnchangeBullets;
    public int bullets;
    public int maxBullets;

    public void MaxBullets()
    {
        bullets = maxBullets;
    }

    private void OnEnable()
    {
        ReloadBehaviour.OnUpdateBullets += ResetBullet; 
    }

    private void OnDisable()
    {
       ReloadBehaviour.OnUpdateBullets -= ResetBullet; 
    }

    private void Start()
    {
        RestartBullets();
    }

    public void RestartBullets()
    {

        bullets = maxBullets;
        OnchangeBullets.Invoke(bullets);
    }

    public void ResetBullet(int d)
    {
        if(bullets > 0)
        {
            bullets -= d; 
           OnchangeBullets.Invoke(bullets);
        }
    }
}
