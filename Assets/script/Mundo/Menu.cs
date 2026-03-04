using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Menu : MonoBehaviour
{
    public void Inicio()
    {
        SceneManager.LoadScene("Examen");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
