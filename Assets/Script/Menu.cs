using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Comenzar()
    {
          Debug.Log("Sali");
          SceneManager.LoadScene("level1");
    }

   public void Salir()
    {
           Debug.Log("Sali");
           Application.Quit();
    }
}
