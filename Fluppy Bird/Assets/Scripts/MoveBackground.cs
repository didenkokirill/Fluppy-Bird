using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private float speed = 0.01f;

    private void Update()
    {
        transform.Translate(-Time.deltaTime, 0, 0, Camera.main.transform);
    }
}