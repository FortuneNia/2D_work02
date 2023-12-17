using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangesceneWithoutField : MonoBehaviour
{
    public TMP_InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Change()
    {
        if(inputField.text == " Menu ")
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
