using TMPro;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText.text = $"Score: {score}";
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            score++;
            scoreText.text = $"Score: {score}";
        }
    }
}
