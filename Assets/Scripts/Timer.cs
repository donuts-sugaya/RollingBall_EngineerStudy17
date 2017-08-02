using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text timeText;

    private float totalTime;
    
    private void Update()
    {
        totalTime += Time.deltaTime;
        timeText.text = "Timer：" + (int)totalTime;
    }
}