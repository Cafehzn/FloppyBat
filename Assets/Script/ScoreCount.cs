using TMPro;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] private AudioSource Point;
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText.text = $"Score: {score}";

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Barrier"))
        {
            //Debug.Log("Point!");
            score++;
            scoreText.text = $"Score: {score++}";
            Point.Play();
        }
    }
}
