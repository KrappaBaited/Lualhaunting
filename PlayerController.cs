using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    public float horizontal;
    public float vertical;
    private bool isFacingRight;
    public bool isWalkingUpWards;
    public static bool isRunning;

    private Animator animator;
    public bool isWalking;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        PlayerMovement();
        HandleAnimation();
        Flip();
    }

    void PlayerMovement()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxis("Vertical");

        isWalkingUpWards = vertical != 0 ? true : false;
        isWalking = horizontal != 0 ? true : false;

        if (!PlayerController.isRunning)
        {
            speed = 2;
        }
        else if (PlayerController.isRunning)
        {
            speed = 5;
        }
    }
    void HandleAnimation()
    {
        animator.SetBool("isWalking", isWalking);
        animator.SetFloat("VerticalMovement", vertical);
        animator.SetBool("isWalkingUpWards", isWalkingUpWards);
    }

    void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector2 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
    }

}