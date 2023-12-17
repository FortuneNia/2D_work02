using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//ห้ามลืม

public class ChangeScene : MonoBehaviour
{
    public string scenename;
    public void LoadScene(string scenename)
    {
        Debug.Log("sceneNae to load: " + scenename);
        SceneManager.LoadScene(scenename);
    }
}
