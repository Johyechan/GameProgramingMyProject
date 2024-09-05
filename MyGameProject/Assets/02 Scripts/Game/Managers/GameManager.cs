using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private GameObject _player;

    private void Awake()
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

        if(pos.x > 1)
        {
            pos.x = 1f;
        }
        if(pos.x < 0)
        {
            pos.x = 0f;
        }

        _player.transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
