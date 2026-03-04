using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Reinicio : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            //GameManager.Instance.enemies = 0;
            SceneManager.LoadScene("Coloso");
        }
    }
}
