using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEgine.SceneManagement;

public class AutoChangescenes : MonoBehaviour
{
    public string scenename;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        invoke("Change")
    }
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void ChangeSceneTest()
    {
        SceneManager.LoadScene(scenename);
    }
}
