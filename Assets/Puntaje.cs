using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puntaje : MonoBehaviour
{
    public Text textExample;
    public float points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdatePoints(int Score)
    {
        points = points + Score;
        textExample.text = "Puntos: " + points;
    }
}
