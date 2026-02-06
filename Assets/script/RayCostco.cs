using UnityEngine;

public class RayCostco : MonoBehaviour
{

    private Transform shootPoint;

    private RaycastHit hit;

    public float fuerza;
    public LayerMask enemyMask;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootPoint = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(shootPoint.position, transform.forward, out hit, 100, enemyMask))
            {
                Debug.Log(hit.transform.name);
                hit.rigidbody.AddForceAtPosition(-hit.normal * fuerza, hit.point);
            }
            
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(shootPoint.position, transform.forward, out hit, 100, enemyMask))
            {
                Debug.Log(hit.transform.name);
                hit.rigidbody.AddForceAtPosition(hit.normal * fuerza, hit.point);
            }

        }

    }
}
