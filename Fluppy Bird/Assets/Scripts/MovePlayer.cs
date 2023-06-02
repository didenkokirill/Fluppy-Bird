using UnityEngine;

public class movePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float force = 7.0f;
    [SerializeField] private KeyCode Key;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
        }
    }
}
