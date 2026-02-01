using UnityEngine;
using UnityEngine.AI;

public class IAMounstro : MonoBehaviour
{
public NavMeshAgent enemy;
public Transform player;

   [Header("Estado")]
    public bool Persiguiendo;

  [Header("Animaciones")]
    public Animator Anim;


void Update()
    {
        enemy.SetDestination(player.position);
    }
}
