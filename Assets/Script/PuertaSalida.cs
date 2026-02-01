using UnityEngine;
using UnityEngine.SceneManagement;

public class PuertaSalida : MonoBehaviour
{
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
             Debug.Log("AA");
             Sonidopuerta.Play();
             Application.Quit();
        }     
             
        }
       
      
    } 
}
