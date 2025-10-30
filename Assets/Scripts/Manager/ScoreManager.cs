using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    int score = 0;

    GameManager gameManager;

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        score = 0;
        scoreText.text = score.ToString();
    }
    public void ModifyScore(int amount)
    {
        if (gameManager.GameOver) return;
        score += amount;
        scoreText.text = score.ToString();

    }
}
