using UnityEngine;

public class CreateBackground : MonoBehaviour
{
    private GameObject background;

    public void BackgoundCreate(Transform parent)
    {
        Vector2 posBackground = new Vector2(parent.position.x + 19.2f, parent.position.y);
        Instantiate(background, posBackground, Quaternion.identity);
    }
}
