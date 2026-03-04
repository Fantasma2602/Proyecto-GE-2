using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Cambio : MonoBehaviour
{
    public Palabras[] palabras;

    //Cosos nuevos
    public string escena;
    public int colNecesarios = 3;

    //Referencia a UI
    [Header("UI")]
    public GameObject sistemaDialogos;
    public TextMeshProUGUI nombre;
    public TextMeshProUGUI texto;
    public Image pers1;
    public Image pers2;
    public Image caja;

    private int linea = 0;

    //Deteccion
    private bool inside;
    [Header("Deteccion")]
    public float radio;
    public LayerMask playerMask;

    private Coroutine rout;
    private bool active = false;

    private void Update()
    {
        inside = Physics.CheckSphere(transform.position, radio, playerMask);

        if (inside && Input.GetKeyDown(KeyCode.E))
        {
           
            if (GameManager.instance.moneda >= colNecesarios)
            {
                SceneManager.LoadScene(escena);
                return;
            }


            Time.timeScale = 0;

            if (!sistemaDialogos.activeSelf)
            {
                linea = 0;
                sistemaDialogos.SetActive(true);
                MostrarLinea();
            }
            else
            {
                if (linea < palabras.Length - 1)
                {
                    linea++;
                    MostrarLinea();
                }
                else
                {
                    CerrarDialogo();
                }
            }
        }
    }

    void MostrarLinea()
    {
        if (active)
            StopCoroutine(rout);

        nombre.text = palabras[linea].nombre;
        pers1.sprite = palabras[linea].pers1;
        pers2.sprite = palabras[linea].pers2;
        caja.sprite = palabras[linea].caja;

        rout = StartCoroutine(Hablar());
    }

    void CerrarDialogo()
    {
        if (active)
            StopCoroutine(rout);

        active = false;
        sistemaDialogos.SetActive(false);
        linea = 0;
        Time.timeScale = 1;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, radio);
    }

    IEnumerator Hablar()
    {
        active = true;
        texto.text = "";
        for (int i = 0; i < palabras[linea].dialogo.Length; i++)
        {
            texto.text += palabras[linea].dialogo[i];
            AudioManager.instance.Play("Hablar");
            yield return new WaitForSecondsRealtime(.1f);
        }

    }
}
