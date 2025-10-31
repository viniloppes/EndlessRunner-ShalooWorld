using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private float startTime = 5.0f;

    
    private bool _gameOver = false;
    private float _currentTime = 0.0f;

    public bool GameOver => _gameOver;
    private void Start()
    {
        _currentTime = startTime;
        gameOverUI.SetActive(false);
    }

    void Update()
    {
        DecreaseTime();
    }

    public void IncreaseTime(float amount)
    {
        _currentTime += amount;
    }
    private void DecreaseTime()
    {
        if (_gameOver) return;
        _currentTime -= Time.deltaTime;
        timeText.text = _currentTime.ToString("F1");
        if (_currentTime <= 0.0f)
        {
            playerController.enabled = false;
            _gameOver = true;
            gameOverUI.SetActive(true);
           // Time.timeScale = 0.1f;
        }
    }
}