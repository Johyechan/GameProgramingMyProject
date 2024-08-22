using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NodeDead : MonoBehaviour
{
    [SerializeField] private NodeSO _nodeSO;

    [SerializeField] private Image _image;

    private float _lifeTime;
    //첫 라이프 타임을 잡아둬서 일정하게 필어마운트가 줄어들게 ㅇㅇ
    void Start()
    {
        _lifeTime = _nodeSO.LifeTime;
        StartCoroutine(DeadTimer());
    }

    void Update()
    {
        
    }

    private IEnumerator DeadTimer()
    {
        while(_lifeTime > 0)
        {
            _lifeTime -= Time.deltaTime;
            _image.fillAmount -= Time.deltaTime / _lifeTime;
            yield return null;
        }
    }
}
