using UnityEngine;

public class BackgroundCreate : MonoBehaviour
{
    public GameObject background;
    [SerializeField] private float plusX = 0;

    public void CreateBackground(Transform parent)
    {
        Vector2 posBackground = new Vector2(parent.position.x + plusX, parent.position.y);
        Instantiate(background, posBackground, Quaternion.identity);
    }
}