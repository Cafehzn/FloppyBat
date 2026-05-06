using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static GameOver instance {  get; private set; }
    public bool isGameOver = false;
    public TextMeshProUGUI GameOverText;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    public void GameOverMethod(string text)
    {
        isGameOver = true;
        GameOverText.gameObject.SetActive(true);
        GameOverText.text = text;
    }
}
