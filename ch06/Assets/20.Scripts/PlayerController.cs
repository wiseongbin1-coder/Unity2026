using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    float jumpForce = 200f;
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
        if (Input.GetMouseButton(0) &&
            rb.linearVelocityY == 0)
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
        else if(rb.linearVelocityY == 0)
        {
            anim.SetBool("IsJumping", false);
        }
        if (time > animationPerio)
            sr.sprite = walkSprites[idx];
        idx++;
        if (idx == walkSprites.Length)
        {
            idx = 0;
        }
        if(transform.position.y < -8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("ClearScene");
        Debug.Log("¼º°ø");
    }
}

    




