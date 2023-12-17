using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoChangescene : MonoBehaviour
{
    public string scenename;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadScene", time);
    }
    public void LoadScee(string scenename)
    {
       SceneManager.LoadScene(scenename);
    }
}
