using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    private float score = 0f;
    [SerializeField] private TextMeshProUGUI scoreText;

    //Aumentar a dificuldade
    private int level = 1;
    private float nextLevel = 10f;


    public GameObject background;
    public Material[] backgroundMaterials;
    private int lastLevel = 1;

    void Update()
    {
        if (PlayerController.instance.gameStarted && !GameOver.instance.isGameOver)
        {
            sistemaPontos();


            if (level > lastLevel)
            {
                ChangeBackground();
                lastLevel = level;
            }
        }

    }

    private void sistemaPontos()
    {
        score += Time.deltaTime;
        scoreText.text = "Run: " + Mathf.FloorToInt(score).ToString();
    }

    public int NextLevel()
    {
        if (score >= nextLevel)
        {
            level++;
            nextLevel += 10f;
        }
        return level;
    }

    private void ChangeBackground()
    {
        if (backgroundMaterials.Length > (level - 1))
        {
            background.GetComponent<Renderer>().material =
                backgroundMaterials[level - 1];
        }
    }



}