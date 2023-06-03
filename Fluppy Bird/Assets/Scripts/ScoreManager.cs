using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // singletone

    [SerializeField] private TMP_Text currentScoreText;
    [SerializeField] private TMP_Text bestScoreText;
    [SerializeField] private int currentScore = 0;
    [SerializeField] private int bestScore;

    private void Awake()
    {
        Instance = this;

        if (PlayerPrefs.HasKey("BestScore"))
        {
            bestScore = PlayerPrefs.GetInt("BestScore");
        }

        bestScoreText.text = $"Best Score: {bestScore}";
    }

    public void AddScore()
    {
        currentScore++;
        currentScoreText.text = $"Current Score: {currentScore}";

        if (currentScore > bestScore)
        {
            bestScore = currentScore;
            bestScoreText.text = $"Best Score: {bestScore}";

            PlayerPrefs.SetInt("BestScore", bestScore);
            PlayerPrefs.Save();
        }
    }
}