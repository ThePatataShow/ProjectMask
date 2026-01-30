using UnityEngine;
using UnityEngine.AI;

public class MounstroRango : MonoBehaviour
{

    public NavMeshAgent Mounstro;
    public float Velocidad;
    public bool Persiguiendo;
    public float Rango;
    public float Distancia;

    public Transform Objetivo;

    void Update()
    {
        Distancia = Vector3.Distance(Mounstro.transform.position, Objetivo.position);

        if (Distancia < Rango)
        {
            Persiguiendo = true;
        }
        else if(Distancia > Rango + 3)
        {
            Persiguiendo = false;
        }
        if (Persiguiendo == false)
        {
            Mounstro.speed = 0;
        }
                if (Persiguiendo == true)
        {
            Mounstro.speed = Velocidad;

            Mounstro.SetDestination(Objetivo.position);
        }
    }

       private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Mounstro.transform.position, Rango);
    }
}
