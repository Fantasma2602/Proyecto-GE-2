using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogos : MonoBehaviour
{
    
    public Palabras[] palabras;


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
        inside = Physics.CheckSphere(transform.position,radio,playerMask);
        
        if(inside && Input.GetKeyDown(KeyCode.E) && linea < palabras.Length -1)
        {
            Time.timeScale = 0;
            if(active)
            {
                StopCoroutine(rout);
                linea++;
            }

            sistemaDialogos.SetActive(true);
            nombre.text = palabras[linea].nombre;
            rout = StartCoroutine(Hablar());
            pers1.sprite = palabras[linea].pers1;
            pers2.sprite = palabras[linea].pers2;
            caja.sprite = palabras[linea].caja;
          
        }
        else if (inside && Input.GetKeyDown(KeyCode.E))
        {
            if (active)
            {
                StopCoroutine(rout);
                active = false;
               
            }

            sistemaDialogos.SetActive(false);
            linea = 0;

            Time.timeScale = 1;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position,radio);
    }

    IEnumerator Hablar()
    {
        active = true;
        texto.text = "";
        for(int i = 0; i < palabras[linea].dialogo.Length; i++)
        {
            texto.text += palabras[linea].dialogo[i];
            AudioManager.instance.Play("Hablar");
            yield return new WaitForSecondsRealtime(.05f);
        }
       
    }
    

}
