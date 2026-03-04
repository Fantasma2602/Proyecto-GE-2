using UnityEngine;

public class SpawnEnemigo : MonoBehaviour
{
    [SerializeField]
    private GameObject enemigo, enemigo2;

    [SerializeField]
    private Transform spawn1, spawn2, spawn3, spawn4;

    private float enemyCont = 20, enemyCont2 = 20, enemyCont3 = 20, enemyCont4 = 20;

    private void Update()
    {
        if (enemyCont <=0 )
        {
            AudioManager.instance.Play("Enemigo");
            GameObject enemy = Instantiate(enemigo2, spawn1.position, enemigo.transform.rotation);
            enemyCont = 500f;
        }
        enemyCont -= Time.deltaTime;
        if (enemyCont2 <= 0)
        {
            AudioManager.instance.Play("Enemigo");
            GameObject enemy = Instantiate(enemigo2, spawn2.position, enemigo.transform.rotation);
            enemyCont2 = 500f;
        }
        enemyCont2 -= Time.deltaTime;

        if (enemyCont3 <= 0)
        {
            AudioManager.instance.Play("Enemigo");
            GameObject enemy = Instantiate(enemigo, spawn3.position, enemigo.transform.rotation);
            enemyCont3 = 500f;
        }
        enemyCont3 -= Time.deltaTime;

        if (enemyCont4 <= 0)
        {
            AudioManager.instance.Play("Enemigo");
            GameObject enemy = Instantiate(enemigo, spawn4.position, enemigo.transform.rotation);
            enemyCont4 = 500f;
        }
        enemyCont4 -= Time.deltaTime;


    }



}

