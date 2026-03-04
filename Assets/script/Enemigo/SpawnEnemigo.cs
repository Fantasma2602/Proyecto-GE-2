using UnityEngine;

public class SpawnEnemigo : MonoBehaviour
{
    [SerializeField]
    private GameObject enemigo, enemigo2;

    [SerializeField]
    private Transform spawn1, spawn2, spawn3, spawn4;

    private float enemyCont = 10, enemyCont2 = 15, enemyCont3 = 20, enemyCont4 = 25;

    private void Update()
    {
        if (enemyCont <=0 )
        {
            GameObject enemy = Instantiate(enemigo2, spawn1.position, enemigo.transform.rotation);
            enemyCont = 30f;
        }
        enemyCont -= Time.deltaTime;
        if (enemyCont2 <= 0)
        {
            GameObject enemy = Instantiate(enemigo2, spawn2.position, enemigo.transform.rotation);
            enemyCont2 = 30f;
        }
        enemyCont2 -= Time.deltaTime;

        if (enemyCont3 <= 0)
        {
            GameObject enemy = Instantiate(enemigo, spawn3.position, enemigo.transform.rotation);
            enemyCont3 = 30f;
        }
        enemyCont3 -= Time.deltaTime;

        if (enemyCont4 <= 0)
        {
            GameObject enemy = Instantiate(enemigo, spawn4.position, enemigo.transform.rotation);
            enemyCont4 = 30f;
        }
        enemyCont4 -= Time.deltaTime;


    }



}

