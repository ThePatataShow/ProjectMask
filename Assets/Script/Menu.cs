using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    void Comenzar()
    {
          Debug.Log("Sali");
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +  1);
    }

   void Exit()
    {
           Debug.Log("Sali");
           Application.Quit();
    }
}
