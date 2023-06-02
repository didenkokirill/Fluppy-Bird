using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    public GameObject block;

    private float timeBtwSpawn;
    [SerializeField] private float startTimeBtwSpawn = 6f;

    [SerializeField] private float startPosition = -5f;
    [SerializeField] private float endPosition = 5f;

    private void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn;
        {
            Vector2 spawnPos = new Vector2(transform.position.x, Random.Range(startPosition, endPosition));
            Instantiate(block, spawnPos, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
    }
    private void Update()
    {
        timeBtwSpawn -= Time.deltaTime;
        if (timeBtwSpawn <= 0)
        {
            Vector2 spawnPos = new Vector2(transform.position.x, Random.Range(startPosition, endPosition));
            Instantiate(block, spawnPos, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
    }
}