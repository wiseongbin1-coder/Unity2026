using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndingUI : MonoBehaviour
{
    public TextMeshProUGUI resultText;

    void Start()
    {
        float finalTime = PlayerPrefs.GetFloat("Time");

        resultText.text =
            "Game CLEAR!!\n\n" +
            "Time : " + finalTime.ToString("F1") + "\n" +
            "Press R to Restart";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("GameScene");
        }
    }
}