using UnityEngine;
using TMPro;

public class PointCollecting : MonoBehaviour
{
    [SerializeField] private TMP_Text CurrentScore;
    [SerializeField] private TMP_Text BestScore;  
    [SerializeField] private int currentScore = 0;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("BestScore"))
        {
            bestScore = 0;
            PlayerPrefs.Save();
        }
        BestScore.text = "Best Score: " + bestScore.ToString();
    }
    [SerializeField] private int bestScore = PlayerPrefs.GetInt("BestScore");

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            currentScore++;
            CurrentScore.text = "Current Score: " + currentScore.ToString();
            if (currentScore > bestScore)
            {
                bestScore=currentScore;
                BestScore.text = "Best Score: " + bestScore.ToString();
                PlayerPrefs.SetInt("BestScore", bestScore) ; PlayerPrefs.Save();
            }
        }
    }
}