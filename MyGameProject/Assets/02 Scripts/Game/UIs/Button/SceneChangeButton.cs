using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeButton : ButtonBase
{
    [SerializeField] private string _sceneName;

    public override void OnClicked()
    {
        base.OnClicked();

        SceneChangeManager.Instance.ChangeScene(_sceneName);
    }
}
