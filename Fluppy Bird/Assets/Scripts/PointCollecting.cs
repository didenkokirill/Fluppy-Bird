using UnityEngine;
using TMPro;

public class PointCollecting : MonoBehaviour
{
    [SerializeField] private TMP_Text Score;
    [SerializeField] private TMP_Text BestScore;
    [SerializeField] private int bestScore = PlayerPrefs.GetInt("BestScore");
    [SerializeField] private int score = 0;

    void Awake()
    {
        BestScore.text = "BestScore: " + bestScore.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            score++;
            Score.text = "Score: " + score.ToString();
            if (score > bestScore)
            {
                bestScore = score;
                PlayerPrefs.SetInt("BestScore", bestScore);
            }
        }
    }
}
