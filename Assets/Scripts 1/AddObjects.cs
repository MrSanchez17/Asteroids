using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AddObjects : MonoBehaviour
{
    public int addCoin;
    public int maxCoin;
    public UnityEvent OnFruit;



    public void AddsCoins()
    {
        addCoin ++;
    }

    public void ResetCoinObject()
    {
        addCoin = 0;
        
    }

    void Update()
    {
        if(addCoin ==  maxCoin)
        {
            OnFruit.Invoke();
        }
    }
}
