using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameObject Player
    {
        get
        {
            if(_player == null)
            {
                _player = GameObject.Find("Player");
            }
            return _player;
        }
    }

    private GameObject _player;

    protected override void Awake()
    {
        base.Awake();
        _player = GameObject.Find("Player");
    }

    public float JumpCalculator(float power)
    {
        return power * 10;
    }

    public void Constraint()
    {
        Vector3 pos = Camera.main.WorldToViewportPoint(_player.transform.position);

        if(pos.x > 0.95f)
        {
            pos.x = 0.95f;
        }
        if(pos.x < 0.05f)
        {
            pos.x = 0.05f;
        }

        _player.transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
