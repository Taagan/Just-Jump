using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public Text text;


    void Update()
    {

        timer = Time.time;
        timer = (int)timer;
        text.text = "" + timer.ToString();
    }
}
