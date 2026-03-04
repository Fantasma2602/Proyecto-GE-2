using UnityEngine;
using UnityEngine.Audio;
using Unity.VisualScripting;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

public class Collect : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {

        if(collision.CompareTag("player"))
        {
            GameManager.instance.moneda++;
            Destroy(gameObject);
        }
        
    }
}
