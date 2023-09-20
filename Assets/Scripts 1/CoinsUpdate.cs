using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoinsUpdate : MonoBehaviour
{
    public int coin;
    public static event Action<int> OnUpdateCoin = delegate { };
    public void UpdateCoin()
    {
        OnUpdateCoin.Invoke(coin);
    }
}

