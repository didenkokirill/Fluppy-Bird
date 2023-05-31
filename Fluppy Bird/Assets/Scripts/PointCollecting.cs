using UnityEngine;
using TMPro;

public class PointCollecting : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private TMP_Text Score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.text = score.ToString();
        }
    }
}
