using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    private float starttime = 0; 

    private void Update()
    {
        starttime += Time.deltaTime;
        scoreText.text = Math.Floor(starttime).ToString();
        Debug.Log(scoreText);
    }
}
