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
 public float DistanciaExtra = 2;

    [Header ("Animaciones")]
    public Animation Anim;
    public string NombreAnimCaminar;
    public string NombreAnimParado;

   
    void Update()
    {
        Distancia = Vector3.Distance(Mounstro.transform.position, Objetivo.position);

        if (Distancia < Rango)
        {
            Persiguiendo = true;
        }
        else if(Distancia > Rango +  DistanciaExtra)
        {
            Persiguiendo = false;
        }
        if (Persiguiendo == false)
        {
            Mounstro.speed = 0;
            Anim.CrossFade(NombreAnimParado);
        }
                if (Persiguiendo == true)
        {
            Mounstro.speed = Velocidad;
            Anim.CrossFade(NombreAnimCaminar);
            Mounstro.SetDestination(Objetivo.position);
        }
    }

       private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Mounstro.transform.position, Rango);
    }
}
