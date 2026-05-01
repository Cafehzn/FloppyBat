using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        if (PlayerController.instance.gameStarted)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

            if (transform.position.x < -10f)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
