using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 moveDir =
            transform.forward * v +
            transform.right * h;

        transform.position += moveDir.normalized * moveSpeed * Time.deltaTime;
    }
}