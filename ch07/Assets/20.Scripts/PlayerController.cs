using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movesSpeed = 10f;
    public float rotationSpeed = 200f;
    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");

        float xSpeed = xInput * rotationSpeed * Time.deltaTime;
        float zSpeed = zinput * movesSpeed * Time.deltaTime;

        transform.Translate(0, 0, zSpeed);
        transform.Rotate(0, xSpeed, 0);
    }
}
