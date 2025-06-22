using System;
using TMPro;
using UnityEngine;

public class HighScoreIndicator : MonoBehaviour
{
    private TextMeshProUGUI gt;

    private int score = 0;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore");
        }
    }

    private void Start()
    {
        gt = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        gt.text = "HighScore: " + score;
    }
}