using UnityEngine;

public class PointCollecting : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            ScoreManager.Instance.AddScore();
        }
    }
}