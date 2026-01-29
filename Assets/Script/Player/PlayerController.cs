using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterController player;
    private PlayerInput playerInput;

    [SerializeField][Range(1, 20)] private float speed = 10.0f;
    [SerializeField][Range(1, 360)] private float rotationSpeed = 180.0f;
    [SerializeField][Range(1, 30)] private float jumpForce = 10.0f;
    [SerializeField][Range(0, 20)] private float slideVelocity = 7;
    [SerializeField][Range(-20, 0)] private float slopeForceDown = -10;

    private float fallVelocity;
    private Vector2 input;

    private void Start()
    {
        player = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        
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
