using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterController playerController;
    private PlayerInput playerInput;
    private Player playerScript;
    [SerializeField][Range(1, 20)] private float speed = 10.0f;
    [SerializeField][Range(1, 360)] private float rotationSpeed = 180.0f;

    private void Start()
    {
        playerController = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();
        playerScript = GetComponentInParent<Player>();
    }

    private void Update()
    {
        if (playerInput.actions["Move"].ReadValue<Vector2>().y == 0)
        {
            playerScript.playerIdle = true;
            playerScript.playerWalking = false;
        }
        else
        {
            playerScript.playerIdle = false;
            playerScript.playerWalking = true;
        }
            
    }
    private void FixedUpdate()
    {
        // Rotate character
        transform.Rotate(Vector3.up, playerInput.actions["Move"].ReadValue<Vector2>().x * rotationSpeed * Time.deltaTime);

        // Move character
        if (playerInput.actions["Move"].ReadValue<Vector2>().y > 0)
        {
            Vector3 moveDirection = transform.forward * playerInput.actions["Move"].ReadValue<Vector2>().y * speed;
            playerController.SimpleMove(moveDirection);
        }
        else
        {
            Vector3 moveDirection = transform.forward * playerInput.actions["Move"].ReadValue<Vector2>().y * speed / 2;
            playerController.SimpleMove(moveDirection);
        }
        playerScript.playerVelocity = playerInput.actions["Move"].ReadValue<Vector2>().y;
    }
 
}
