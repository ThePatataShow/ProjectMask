using UnityEngine;

public class Puertas : MonoBehaviour
{

    public Transform Destino;
    private AudioSource Sonidopuerta;


private void Start()
    {
        Sonidopuerta = GetComponent<AudioSource>();
    }
    private void OnTriggerStay(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
                    if (Input.GetKeyDown(KeyCode.F))
        {
             Debug.Log("ff");
             Sonidopuerta.Play();
             other.transform.position = Destino.transform.position;
       
        }     
             
        }
       
      
    } 


}
