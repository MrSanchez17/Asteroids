using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ReloadBehaviour : MonoBehaviour
{
    public int bullets;
    public static event Action<int> OnUpdateBullets = delegate { };
    public void UpdateBullets()
    {
        OnUpdateBullets.Invoke(bullets);
    }
}
