using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinsBehavior : MonoBehaviour
{
    public int coin;
    public UnityEvent<int> OnChangeCoin;

    private void OnEnable()
    {
        CoinsUpdate.OnUpdateCoin += AddCoin;
    }

    private void OnDisable()
    {
       CoinsUpdate.OnUpdateCoin -= AddCoin;
    }

    public void Start()
    {
        coin = 0;
    }
    public void AddCoin(int d)
    {
        coin += d;
        OnChangeCoin.Invoke(coin);
    }
    public void RestartCoin()
    {
        coin = 0;
        OnChangeCoin.Invoke(coin);
    }
}
