using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _rigid2D;

    [SerializeField] private float _moveSpeed;

    private void Start()
    {
        _rigid2D = GetComponent<Rigidbody2D>();
    }

    public void Move()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _rigid2D.velocity = new Vector2(-_moveSpeed, _rigid2D.velocity.y);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            _rigid2D.velocity = new Vector2(_moveSpeed, _rigid2D.velocity.y);
        }
        else
        {
            _rigid2D.velocity = new Vector2(0, _rigid2D.velocity.y);
        }
    }
}
