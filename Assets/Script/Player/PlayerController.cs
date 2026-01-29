using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterController player;
    private PlayerInput playerInput;

    [SerializeField][Range(1, 20)] private float speed = 10.0f;
    [SerializeField][Range(1, 360)] private float rotationSpeed = 180.0f;

    private void Start()
    {
        player = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();
    }

    private void FixedUpdate()
    {
        // Rotate character
        transform.Rotate(Vector3.up, playerInput.actions["Move"].ReadValue<Vector2>().x * rotationSpeed * Time.deltaTime);

        // Move character
        Vector3 moveDirection = transform.forward * playerInput.actions["Move"].ReadValue<Vector2>().y * speed;

        player.SimpleMove(moveDirection);
    }
 
}
