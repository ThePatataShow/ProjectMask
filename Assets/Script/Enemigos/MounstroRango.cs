using UnityEngine;
using UnityEngine.AI;

public class MounstroRango : MonoBehaviour
{
    [Header("Movimiento")]
    public NavMeshAgent Mounstro;
    public float Velocidad = 3.5f;
    public float Rango = 10f;
    public float DistanciaExtra = 2f;

    [Header("Estado")]
    public bool Persiguiendo;
    public float Distancia;

    [Header("Objetivo")]
    public Transform Objetivo;

    [Header("Animaciones")]
    public Animator Anim;

    void Awake()
    {
        // Auto-asignación para evitar errores
        if (Mounstro == null)
            Mounstro = GetComponent<NavMeshAgent>();

        if (Anim == null)
            Anim = GetComponent<Animator>();
    }

   void Update()
{
    if (Mounstro == null || Anim == null || Objetivo == null)
        return;

    // ⚠️ CLAVE: si no está en NavMesh, no hacemos nada
    if (!Mounstro.isOnNavMesh)
        return;

    Distancia = Vector3.Distance(
        Mounstro.transform.position,
        Objetivo.position
    );

    if (Distancia < Rango)
        Persiguiendo = true;
    else if (Distancia > Rango + DistanciaExtra)
        Persiguiendo = false;

    if (Persiguiendo)
    {
        Anim.SetBool("Persiguiendo", true);

        Mounstro.isStopped = false;
        Mounstro.speed = Velocidad;
        Mounstro.SetDestination(Objetivo.position);
    }
    else
    {
        Anim.SetBool("Persiguiendo", false);
        Mounstro.isStopped = true;
    }
}


    private void OnDrawGizmos()
    {
        if (Mounstro == null) return;

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Mounstro.transform.position, Rango);
    }
}
