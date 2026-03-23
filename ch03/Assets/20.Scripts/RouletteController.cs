using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    float startspeed = 30f;
    float decreaseRatio = 0.99f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = startspeed;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        this.rotSpeed *= 0.99f;
    }
}
