using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] private TMP_Text _tmp;

    void Update()
    {
        _tmp.text = ScoreManager.Instance.Score.ToString();
    }
}
