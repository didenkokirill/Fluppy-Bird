
using UnityEngine;

public class Pause : MonoBehaviour
{

    void Start()
    {
        Time.timeScale = 0; /* астыль надо что бы это зависило от строчки 11*/
    }
    [SerializeField] private int paused = 1;
    [SerializeField] private int playing = 0;
    void Update()
    {
        if (playing == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (paused == 1)
                {
                    Time.timeScale = 0;
                    paused = 1;
                }
                else
                {
                    Time.timeScale = 1;
                    paused = 0;
                    playing = 1;
                }
            }
            
        }
    }
}
