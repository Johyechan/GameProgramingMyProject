using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    public int Score
    {
        get
        {
            return _score;
        }
    }

    private int _score;

    protected override void Awake()
    {
        base.Awake();

        _score = 0;
    }

    public void IncreaseScore()
    {
        _score++;
    }
}
