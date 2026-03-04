using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using Unity.VisualScripting;

public class Menu : MonoBehaviour
{
    public void Inicio()
    {
        AudioManager.instance.Play("inicio");
        SceneManager.LoadScene("Examen");
    }
    public void Salir()
    {
        AudioManager.instance.Play("salir");
        Application.Quit();
    }
}
