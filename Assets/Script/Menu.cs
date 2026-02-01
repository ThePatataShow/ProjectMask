using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Comenzar()
    {
          Debug.Log("Sali");
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +  1);
    }

   public void Salir()
    {
           Debug.Log("Sali");
           Application.Quit();
    }
}
