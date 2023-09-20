using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ScoreBehaviour : MonoBehaviour
{
    public int score;
    public UnityEvent<int> OnChangeScore;
    private int objects;

    private void OnEnable()
    {
        ScoreUpdate.OnUpdateScore += AddScore;
    }

    private void OnDisable()
    {
        ScoreUpdate.OnUpdateScore -= AddScore;
    }

    private void Start()
    {
        score = 0;
    }
    public void AddScore(int d)
    {
        score += d;
        OnChangeScore.Invoke(score);
    }
    public void RestartScore()
    {
        score = 0;
        OnChangeScore.Invoke(score);
    }

    public void ExtraScore()
    {
        if(objects == 5)
        {
            score = score + 500;
            OnChangeScore.Invoke(score);
        }
    }
}
