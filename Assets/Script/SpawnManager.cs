using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;//Obstacle to be spawned
    public float spawnInterval = 2f;//Spawn interval
    public Vector3 spawnPosition = new Vector3(14f, -2f, 0f);//Where the obstacle will spawn
    private float timer;//Obstacle spawn timer

    //Game dificulty
    private float MinimumY = -1.6f;
    private float MaximumY = 0.6f;

    private void Update()
    {
        if (PlayerController.instance.gameStarted)
        {
            timer -= Time.deltaTime;
            if (timer < 0f)
            {
                SpawnObstacle();//Method bellow
                timer = spawnInterval;//Reset count
            }
        }

    }
    void SpawnObstacle()
    {
        spawnPosition.y = Random.Range(MinimumY, MaximumY);//Randomize Y when spawn
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);//Obstacle instance
    }
}
