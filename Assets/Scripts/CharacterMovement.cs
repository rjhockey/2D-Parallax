using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float characterMoveSpeed;
    private float dirX;

    // Start is called before the first frame update
    void Start()
    {
        //characterMoveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        // determine left or right keyboard input
        dirX = Input.GetAxis("Horizontal") * characterMoveSpeed * Time.deltaTime;
        // moves player to left or right
        transform.position = new Vector2(transform.position.x + dirX, transform.position.y);
    }
}
