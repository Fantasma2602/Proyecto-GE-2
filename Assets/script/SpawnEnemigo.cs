using UnityEngine;

public class SpawnEnemigo : MonoBehaviour
{
    [SerializeField]
    private GameObject enemigo, enemigo2;

    [SerializeField]
    private Transform spawn1, spawn2, spawn3, spawn4;

    private float enemyCont = 3, enemyCont2 = 3, enemyCont3 = 3, enemyCont4 = 3;

    private void Update()
    {
        if (enemyCont <=0 )
        {
            GameObject enemy = Instantiate(enemigo2, spawn1.position, enemigo.transform.rotation);
            enemyCont = 10f;
        }
        enemyCont -= Time.deltaTime;
        if (enemyCont2 <= 0)
        {
            GameObject enemy = Instantiate(enemigo2, spawn2.position, enemigo.transform.rotation);
            enemyCont2 = 10f;
        }
        enemyCont2 -= Time.deltaTime;

        if (enemyCont3 <= 0)
        {
            GameObject enemy = Instantiate(enemigo, spawn3.position, enemigo.transform.rotation);
            enemyCont3 = 10f;
        }
        enemyCont3 -= Time.deltaTime;

        if (enemyCont4 <= 0)
        {
            GameObject enemy = Instantiate(enemigo, spawn4.position, enemigo.transform.rotation);
            enemyCont4 = 10f;
        }
        enemyCont4 -= Time.deltaTime;


    }



}

