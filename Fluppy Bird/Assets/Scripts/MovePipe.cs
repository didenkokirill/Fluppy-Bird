using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float speed = 0.01f;
    [SerializeField] private float lifeTime = 0;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        transform.Translate(-Time.deltaTime, 0, 0, Camera.main.transform);
    }
}