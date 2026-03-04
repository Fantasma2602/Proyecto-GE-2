using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;
    public int moneda = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }
    public void ReiniciarDatos()
    {
        moneda = 0;
    }
}
