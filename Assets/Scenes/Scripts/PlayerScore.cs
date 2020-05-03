using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text scoreText;

    private float starttime = 0;
    public bool gameover = false;

    private void Update()
    {
        if (!gameover)
        {
            starttime += Time.deltaTime;
            scoreText.text = Math.Floor(starttime).ToString();
        }
    }
}
