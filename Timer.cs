using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// code: https://www.youtube.com/watch?v=hxpUk0qiRGs&t=47s

public class Timer : MonoBehaviour
{
    public float timeLeft;
    public bool timerOn = false;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn == true)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                UpdateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time is Up");
                timeLeft = 0;
                timerOn = false;
            }
        }
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00} : {1:00} time till impact.", minutes, seconds);
    }

}
