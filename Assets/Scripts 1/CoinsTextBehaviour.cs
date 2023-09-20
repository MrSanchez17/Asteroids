using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsTextBehaviour : MonoBehaviour
{
    public void SetScoreText(int coin)
    {
        GetComponent<TMP_Text>().text = "Coins: " + coin;
    }
}