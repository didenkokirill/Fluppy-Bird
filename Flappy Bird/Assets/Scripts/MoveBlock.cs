using System.Threading.Tasks;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    [SerializeField] private float speed = 0.01f;

    private void Update()
    {
        transform.Translate(Vector2.left * speed);
    }
}
