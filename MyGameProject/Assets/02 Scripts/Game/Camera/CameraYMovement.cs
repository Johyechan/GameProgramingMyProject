using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraYMovement : MonoBehaviour
{
    private GameObject _player;

    [SerializeField] private float _cameraSpeed;

    private void Awake()
    {
        _player = GameManager.Instance.Player;
    }

    private void LateUpdate()
    {
        if(_player.transform.position.y > 4.5f)
        {
            Vector3 newPos = new (0, _player.transform.position.y, -10);

            Vector3 smoothedPos = Vector3.Lerp(Camera.main.transform.position, newPos, _cameraSpeed);

            Camera.main.transform.position = smoothedPos;
        }
        else
        {
            Vector3 smoothedPos = Vector3.Lerp(Camera.main.transform.position, new Vector3(0, 0, -10), _cameraSpeed);

            Camera.main.transform.position = smoothedPos;
        }
    }
}
