using UnityEngine;

public class MainCameraMovement : MonoBehaviour
{
    [SerializeField] private Transform characterPosition; // drag player onto slot

    // Update is called once per frame
    void Update()
    {
        // camera follows the player position
        transform.position = new Vector3(characterPosition.position.x, transform.position.y, transform.position.z);
    }
}
