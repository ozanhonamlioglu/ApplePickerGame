using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{

    private TextMeshProUGUI _scoreGt;
    private Camera _mainCamera;
    private int lv0Cap = 2000;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        _scoreGt = scoreGO.GetComponent<TextMeshProUGUI>();
        _scoreGt.text = "0";
    }


    private void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
            int score = int.Parse(_scoreGt.text);
            score += 100;
            _scoreGt.text = score.ToString();
            
            if (score > HighScore.score) {
                HighScore.score = score;
            }

            // Change level after level cap reached
            if (score > lv0Cap && SceneManager.GetActiveScene().name == "Scene_0")
            {
                SceneManager.LoadScene("Scene_1");
            }
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // Use Mouse.current from the new Input System
        if (Mouse.current == null) return; // Safety check

        Vector2 mousePosition = Mouse.current.position.ReadValue();

        // Convert screen position to world position
        Vector3 screenPosition = new Vector3(mousePosition.x, mousePosition.y, -_mainCamera.transform.position.z);
        Vector3 worldPosition = _mainCamera.ScreenToWorldPoint(screenPosition);

        // Move the basket's x-position
        Vector3 newPosition = transform.position;
        newPosition.x = worldPosition.x;
        transform.position = newPosition;
    }
}