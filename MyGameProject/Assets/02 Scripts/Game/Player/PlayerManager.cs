using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private PlayerMovement _movement;

    private Rigidbody2D _rigid2D;

    [SerializeField] private float _jumpPower;

    void Start()
    {
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
        if(collision.gameObject.tag == "StartFloor")
        {
            _rigid2D.AddForce(Vector2.up * GameManager.Instance.JumpCalculator(_jumpPower));
            _jumpPower += 5;
        }
        else
        {
            // ªÁ∏¡ æ¿¿∏∑Œ
        }
    }
}
