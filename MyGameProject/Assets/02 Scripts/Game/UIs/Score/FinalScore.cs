using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    [SerializeField] private TMP_Text _tmp;

    void Start()
    {
        _tmp.text = ScoreManager.Instance.Score.ToString();
    }
}
