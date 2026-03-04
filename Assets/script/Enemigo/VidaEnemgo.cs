using UnityEngine;

public class VidaEnemgo : MonoBehaviour
{
    public int vida;

    public void DanioEnemigo(int danio)
    {
        vida -= danio;
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
