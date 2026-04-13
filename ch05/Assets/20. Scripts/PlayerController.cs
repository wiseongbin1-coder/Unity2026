using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float Speed = 0.5f;
    void Start()
    { 
        Application.targetFrameRate = 60;
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.LeftArrow))
    //    {
    //        transform.Translate(-Speed, 0, 0);
    //    }

    //    if (Input.GetKeyDown(KeyCode.RightArrow))
    //    {
    //        transform.Translate(Speed, 0, 0);
    //    }
    //}

    public void LButtonDown()
    {
        transform.Translate(-Speed, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(Speed, 0, 0);
    }
}
