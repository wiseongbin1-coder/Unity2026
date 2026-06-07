using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI coinText;

    private float survivalTime = 0f;
    private int coinCount = 0;
    private bool isGameOver = false;

    public int winCoinCount = 10; 

    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }
    void Update()
    {
        if (!isGameOver)
        {
            survivalTime += Time.deltaTime;
            timeText.text = "Time : " + survivalTime.ToString("F1");
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    public void GameOver()
    {
        isGameOver = true;

        gameOverText.gameObject.SetActive(true);
        gameOverText.text =
            "GAME OVER\n" +
            "Press R to Restart";

        Time.timeScale = 0f;
    }
    public void AddCoin(int amount)
    {
        coinCount += amount;
        coinText.text = "Coin : " + coinCount;

        if (coinCount >= winCoinCount)
        {
            WinGame();
        }
    }
    void WinGame()
    {
        isGameOver = true;
        PlayerPrefs.SetFloat("Time", survivalTime);
        Debug.Log("CLEAR!");
        Time.timeScale = 0f;
        SceneManager.LoadScene("EndingScene");
    }
}