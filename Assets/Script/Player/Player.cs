
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;

    [SerializeField][Range(1, 5)] private int lives;

    private bool idle, walking, action, damage, death;
    private int keys;
    private float velocity;

    public bool playerIdle { get { return idle; } set { idle = value; } }
    public bool playerWalking { get { return walking; } set { walking = value; }}
    public float playerVelocity { get { return velocity; } set { velocity = value; } }
    public bool playerAction { get { return action; } set { action = value; }}
    public bool playerDamage { get { return damage; } set { damage = value; } }
    public bool playerDeath { get { return death; } set { death = value; } }

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        idle = true;
        walking = false;
        action = false;
        damage = false;
        death = false;
        velocity = 0;
        lives = 3;
        keys = 0;
    }

    private void Update()
    {
        animator.SetBool("Idle", idle);
        animator.SetBool("Walking", walking);
        animator.SetBool("Action", action);
        animator.SetBool("Damage", damage);
        animator.SetBool("Death", death);
        animator.SetFloat("Velocity", velocity);
    }

    public void KeyFound()
    {
        keys++;
    }

}
