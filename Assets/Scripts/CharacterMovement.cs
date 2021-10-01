//using UnityEngine;

//public class CharacterMovement : MonoBehaviour
//{
//    [SerializeField] private float characterMoveSpeed;
//    public float jumpSpeed = 8f;
//    private float dirX;
//    private Rigidbody2D rb;

//    // Start is called before the first frame update
//    void Start()
//    {
//        //characterMoveSpeed = 5f;
//        rb = GetComponent<Rigidbody2D>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        // determine left or right keyboard input
//        dirX = Input.GetAxis("Horizontal") * characterMoveSpeed * Time.deltaTime;
//        // moves player to left or right
//        transform.position = new Vector2(transform.position.x + dirX, transform.position.y);

//        if (Input.GetButtonDown("Jump"))
//        {
//            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
//        }
//    }
//}

using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 8f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        if (movement > 0f)
        {
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
        }
        else if (movement < 0f)
        {
            rigidBody.velocity = new Vector2(movement * speed, rigidBody.velocity.y);
        }
        else
        {
            rigidBody.velocity = new Vector2(0, rigidBody.velocity.y);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }
    }
}