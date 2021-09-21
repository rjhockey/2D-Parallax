using UnityEngine;

public class ParallaxBackgroundMovement : MonoBehaviour
{
    [SerializeField] private Transform mainCameraPosition; // drag main camera onto slot

    [SerializeField] private float backgroundMoveSpeed;
    [SerializeField] private float directionX;

    [SerializeField] private float offsetByX = 13f;

    // Update is called once per frame
    void Update()
    {
        directionX = Input.GetAxis("Horizontal") * backgroundMoveSpeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + directionX, transform.position.y);

        if (transform.position.x - mainCameraPosition.position.x < -offsetByX)
        {
            transform.position = new Vector2(mainCameraPosition.position.x + offsetByX, transform.position.y);
        }
        else if (transform.position.x - mainCameraPosition.position.x > offsetByX)
        {
            transform.position = new Vector2(mainCameraPosition.position.x - offsetByX, transform.position.y);
        }
    }
}
