using UnityEngine;

public class Bala : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<VidaEnemgo>().DanioEnemigo(100);
            Destroy(gameObject);
        }
    }

}
