using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float jumpForce = 50f;
    public float walkForce = 7f;
    float maxWalkSpeed = 1f;
    Animator anim;

    public Sprite[] walkSprites;
    public Sprite jumpSprites;
    public float animationPerio = 0.2f;
    float time = 0;
    int idx = 0;
    SpriteRenderer sr;

    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rb.AddForce(transform.up * jumpForce);
        }

        if (rb.linearVelocityX < maxWalkSpeed)
        {
            rb.AddForce(transform.right * walkForce);
        }

        time += Time.deltaTime;

        if (rb.linearVelocityY != 0)
        {
            anim.SetBool("IsJumping", true);
        }
        if (time > animationPerio)
            sr.sprite = walkSprites[idx];
        idx++;
        if (idx == walkSprites.Length)
        {
            idx = 0;
        }
   }
            private void OnCollisionEnter(Collision collision)
            {
                Debug.Log("¼º°ø");
            }
}
    




