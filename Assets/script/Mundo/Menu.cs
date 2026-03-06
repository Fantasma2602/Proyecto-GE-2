using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
using Unity.VisualScripting;
using System.Collections;

public class Menu : MonoBehaviour
{
    public void Inicio()
    {
        AudioManager.instance.Play("inicio");
        SceneManager.LoadScene("Examen");
    }
    public void Salir()
    {
        StartCoroutine(SalirConSonido());
    }
    IEnumerator SalirConSonido()
    {
        AudioManager.instance.Play("salir");
        yield return new WaitForSeconds(2f); 
        Application.Quit();
    }



}
