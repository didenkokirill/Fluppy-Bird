
using UnityEngine;
using UnityEngine.SceneManagement;

public class RemovePipe : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Killer")
        {
            Destroy(collision.gameObject);  
        }
    }
}
