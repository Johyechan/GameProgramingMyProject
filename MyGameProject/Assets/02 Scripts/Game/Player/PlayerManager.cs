using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerManager : MonoBehaviour
{
    private event Action DieEventAction;

    private PlayerMovement _movement;

    private Rigidbody2D _rigid2D;

    [SerializeField] private float _jumpPower;
    [SerializeField] private float _jumpPowerIncrease;

    void Start()
    {
        DieEventAction += SceneChangeManager.Instance.DieEvent;
        _movement = GetComponent<PlayerMovement>();
        _rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        GameManager.Instance.Constraint();
        _movement.Move();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("StartFloor"))
        {
            _rigid2D.AddForce(Vector2.up * GameManager.Instance.JumpCalculator(_jumpPower));
            _jumpPower += _jumpPowerIncrease;
            ScoreManager.Instance.IncreaseScore();
        }
        else
        {
            DieEventAction?.Invoke();
        }
    }
}
