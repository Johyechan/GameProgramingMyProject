using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : Singleton<SceneChangeManager>
{
    public void DieEvent()
    {
        ChangeScene("End");
    }

    public void ChangeScene(string str)
    {
        SceneManager.LoadScene(str);
    }
}
