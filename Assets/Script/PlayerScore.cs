using TMPro;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private float score = 0f;
    [SerializeField] private TextMeshProUGUI scoreText;

    private int level = 1;
    private float nextLevel = 10f;

    private void Update()
    {
        if (PlayerController.instance.gameStarted)
        {
            PointSystem();
        }
    }

    private void PointSystem()
    {
        score += Time.deltaTime;
        scoreText.text = "Run: " + Mathf.FloorToInt(score).ToString();
    }

    public int LevelUp()
    {
        if (score >= nextLevel)
        {
            level++;
            nextLevel *= 10f;
        }
        return level;
    }
}
