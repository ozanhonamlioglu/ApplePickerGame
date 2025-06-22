using System;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    static public int score = 0;

    private TextMeshProUGUI gt;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore");
        }

        PlayerPrefs.SetInt("HighScore", score);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        gt.text = "High Score: " + score;

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}