using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform player;
    //detrect
    private bool detected;
    [SerializeField] private float radio;
    [SerializeField] private LayerMask whatIsPlayer;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        detected = Physics.CheckSphere(transform.position,radio,whatIsPlayer);

        if (detected)
        {
            player = GameObject.FindGameObjectWithTag("player").transform;
            agent.SetDestination(player.position);
        }
        
    }

    //Muerte de jugador y reinicio de mundo
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Coloso");
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radio);
    }

}


