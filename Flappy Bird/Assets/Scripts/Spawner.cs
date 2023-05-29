using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Block;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn = 6f;

    public float startPosition = -5f;
    public float endPosition = 5f;

    private void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn;
        {
            Vector2 spawnPos = new Vector2(transform.position.x, Random.Range(startPosition, endPosition));
            Instantiate(Block, spawnPos, Quaternion.identity);
        }
    }
    private void Update()
    {
        timeBtwSpawn -= Time.deltaTime;
        if (timeBtwSpawn <= 0)
        {
            Vector2 spawnPos = new Vector2(transform.position.x, Random.Range(startPosition, endPosition));
            Instantiate(Block, spawnPos, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
    }
}