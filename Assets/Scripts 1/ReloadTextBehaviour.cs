using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReloadTextBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public void SetScoreText(int bullets)
    {
        GetComponent<TMP_Text>().text = "Bullets: " + bullets;
    }
}
