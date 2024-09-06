using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : ButtonBase
{
    public override void OnClicked()
    {
        base.OnClicked();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
