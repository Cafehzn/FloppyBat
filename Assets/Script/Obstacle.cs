using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private PlayerScore scoreScript;

    private void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerScore>();
    }

    private void Update()
    {
        if (PlayerController.instance.gameStarted)
        {
            speed = 5f + scoreScript.LevelUp();

            transform.position += Vector3.left * speed * Time.deltaTime;

            if (transform.position.x < -10f)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
