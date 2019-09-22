using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

    public Animator animator;

    public float moveSpeed = 20f;
    float horizontalMove = 0;
    bool isJump = false;
    private bool m_FacingRight = true;
    private Vector3 m_Velocity = Vector3.zero;
    public bool ground = true;
    public bool falling = false;
    public float m_JumpForce = 400f;
    public bool jumping = false;

    private Rigidbody2D m_Rigidbody2D;
    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;  // How much to smooth out the movement

    private void Awake()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        animator.SetBool("ground", ground);
        animator.SetBool("falling", falling);

        isJump = Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W);
    }

    private void FixedUpdate()
    {
        Move(horizontalMove * Time.fixedDeltaTime, isJump);
    }

    public void Move(float move, bool jump)
    {
        Vector3 targetVelocity = new Vector2(move * 10f, m_Rigidbody2D.velocity.y);
        m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
        if (move > 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (move < 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }

        if (ground && isJump)
        {
            ground = false;
            m_Rigidbody2D.AddForce(new Vector2(0f, m_JumpForce));
            jumping = true;
        }

        if (!ground && !jumping)
        {
            falling = true;
        }

    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            ground = true;
            jumping = false;
            falling = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            ground = false;
        }
    }

}
