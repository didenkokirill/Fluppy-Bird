using UnityEngine;

public class Pointer : MonoBehaviour
{
    [SerializeField] private CreateBackground backgroundCreate;

    private void Awake()
    {
        backgroundCreate = FindObjectOfType<CreateBackground>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            backgroundCreate.BackgoundCreate(transform.parent);
            Destroy(gameObject);
        }
    }
}