using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;

    void Start()
    {
        int score = PlayerPrefs.GetInt("Score",0);
        ScoreText.text = score.ToString();

    }
    public void OnTryAgainPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnQuitPressed()
    {
        Application.Quit();
    }

}
