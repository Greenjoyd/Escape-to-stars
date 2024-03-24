using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int maxEnemy = 5;
    public float timeSpawn = 2f;
    public float distance = 3f;
    public float spawnHeight = 5f; 

    private float timer;

    private void Start()
    {
        timer = timeSpawn;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeSpawn;
            if (transform.childCount < maxEnemy)
            {
                Vector3 spawnPosition = new Vector3(Random.insideUnitCircle.x * distance, spawnHeight, Random.insideUnitCircle.y * distance);
                Instantiate(enemyPrefab, spawnPosition, Quaternion.identity, transform);
            }
        }
    }
}
