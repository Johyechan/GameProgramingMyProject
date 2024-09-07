using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private GameObject _player;

    private float _lastSpawnY;
    [SerializeField] private float _interval;

    [SerializeField] private GameObject _obstacle1;
    [SerializeField] private GameObject _obstacle2;
    [SerializeField] private GameObject _obstacle3;
    [SerializeField] private GameObject _obstacle4;
    [SerializeField] private GameObject _obstacle5;
    [SerializeField] private GameObject _obstacle6;
    [SerializeField] private GameObject _obstacle7;

    private void Start()
    {
        _player = GameManager.Instance.Player;
        _lastSpawnY = -_interval;
    }
    void Update()
    {
        if(_player.transform.position.y > _lastSpawnY)
        {
            int randomObj = Random.Range(0, 7);
            _lastSpawnY += _interval;
            SpawnObstacle(randomObj, new Vector3(0, _lastSpawnY, 0));
        }
    }

    private void SpawnObstacle(int random, Vector3 pos)
    {
        switch (random)
        {
            case 0:
                MakeObstacle(_obstacle1, pos);
                break;
            case 1:
                MakeObstacle(_obstacle2, pos);
                break;
            case 2:
                MakeObstacle(_obstacle3, pos);
                break;
            case 3:
                MakeObstacle(_obstacle4, pos);
                break;
            case 4:
                MakeObstacle(_obstacle5, pos);
                break;
            case 5:
                MakeObstacle(_obstacle6, pos);
                break;
            case 6:
                MakeObstacle(_obstacle7, pos);
                break;
        }
    }

    private void MakeObstacle(GameObject obj, Vector3 pos)
    {
        GameObject obstacle = Instantiate(obj, transform);
        obstacle.transform.position = pos;
    }
}
