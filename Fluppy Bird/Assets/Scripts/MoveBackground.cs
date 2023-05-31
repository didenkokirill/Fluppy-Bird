using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private float speed = 1f;

    private void Update()
    {
        transform.Translate(-Time.deltaTime * speed, 0, 0, Camera.main.transform);
    }
}