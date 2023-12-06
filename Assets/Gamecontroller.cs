using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Gamecontroller : MonoBehaviour
{
    public Button btnStart;
    void Start()
    {
        btnStart.onClick.AddListener(() => DoSomething());
    }
    void Update()
    {
 
    }
    public void DoSomething()
    {
        SceneManager.LoadScene("Level1");
    }
}
