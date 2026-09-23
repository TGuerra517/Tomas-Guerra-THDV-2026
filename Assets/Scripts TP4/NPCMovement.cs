using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] float distanciaPersecucion = 10f;
    [SerializeField] float velocidad = 3f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float distancia = Vector3.Distance(transform.position, Player.position);

        if (distancia <= distanciaPersecucion)
        {
            Vector3 direccion = Player.position - transform.position;
            direccion.y = 0;

            rb.linearVelocity = direccion.normalized * velocidad;
        }
        else
        {
            rb.linearVelocity = Vector3.zero;
        }

    }


    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, distanciaPersecucion);
    }
}  
