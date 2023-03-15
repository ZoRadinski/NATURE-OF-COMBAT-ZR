
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeLeft = 10.0f; //time in seconds
    public TextMeshProUGUI timeText;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeText.text = timeLeft.ToString("0");

        if (timeLeft <= 0.0f)
        {
            SceneManager.LoadScene("Win");
        }
    }
}