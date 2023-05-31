using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed = 1f;
    [SerializeField] private float lifeTime = 0;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        transform.Translate(-Time.deltaTime * speed, 0, 0, Camera.main.transform);
    }
}