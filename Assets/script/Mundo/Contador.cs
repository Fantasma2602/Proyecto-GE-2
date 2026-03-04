using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    private TextMeshProUGUI texto;

    private void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        texto.text = "Zanahoria " + GameManager.instance.moneda;
    }

}
