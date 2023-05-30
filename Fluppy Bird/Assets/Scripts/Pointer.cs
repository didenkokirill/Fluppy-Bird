using UnityEngine;

public class Pointer : MonoBehaviour
{
    private BackgroundCreate backgroundCreate;

    private void Awake()
    {
        backgroundCreate = FindObjectOfType<BackgroundCreate>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            backgroundCreate.CreateBackground(transform.parent);
            Destroy(gameObject);
        }
    }
}