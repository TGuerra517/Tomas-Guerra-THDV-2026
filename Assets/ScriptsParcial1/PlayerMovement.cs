
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 5f;

    PlayerStats stats;
    Rigidbody rb;
    bool estaEnElPiso;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        stats = GetComponent<PlayerStats>();
    }

    void Update()
    {
        if (stats.vida <= 0)
        {
            rb.linearVelocity = Vector3.zero;
            return;
        }

        float movimientoX = Input.GetAxis("Horizontal");
        float movimientoZ = Input.GetAxis("Vertical");

        // Movimiento relativo a la orientación del jugador
        Vector3 movimiento = transform.right * movimientoX
                           + transform.forward * movimientoZ;

        // Evitamos que el movimiento horizontal modifique la altura
        movimiento.y = 0f;
        movimiento = Vector3.ClampMagnitude(movimiento, 1f);

        // Conservamos la velocidad vertical para permitir saltar y caer
        rb.linearVelocity = new Vector3(
            movimiento.x * velocidad,
            rb.linearVelocity.y,
            movimiento.z * velocidad
        );

        if (Input.GetKeyDown(KeyCode.Space) &&
            estaEnElPiso &&
            stats.estamina >= 5)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            stats.estamina -= 5;
        }
    }

    void OnCollisionStay(Collision collision)
    {
        estaEnElPiso = true;
    }

    void OnCollisionExit(Collision collision)
    {
        estaEnElPiso = false;
    }
}
