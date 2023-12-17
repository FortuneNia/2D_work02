using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSecene : MonoBehaviour
{
    public string sceneName;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadScene", time);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
