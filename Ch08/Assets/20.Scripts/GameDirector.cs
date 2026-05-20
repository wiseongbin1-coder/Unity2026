using UnityEngine;
using TMPro;


public class GameDirector : MonoBehaviour
{
    public GameObject timeText;
    public GameObject pointText;

    int point = 0;
    float time = 60.0f;

    public void GetApple()
    {
        point += 100;
    }
    public void GetBomb()
    {
        point /= 2;
    }

    private void Start()
    {
        timeText = GameObject.Find("Time");
        pointText = GameObject.Find("Point");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        if (time < 0) return;

        time -= Time.deltaTime;
        timeText.GetComponent<TextMeshProUGUI>().text =
           "Time : " +  time.ToString("F1");

        pointText.GetComponent<TextMeshProUGUI>().text =
           "Point : " + point;
    }
}

