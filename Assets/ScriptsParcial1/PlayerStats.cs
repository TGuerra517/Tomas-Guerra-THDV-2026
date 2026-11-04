
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float vida = 100;
    public float estamina = 10;

    Vector3 posicionInicial;
    Quaternion rotacionInicial;
    Rigidbody rb;

    void Start()
    {
        posicionInicial = transform.position;
        rotacionInicial = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        estamina += 2 * Time.deltaTime;
        estamina = Mathf.Clamp(estamina, 0, 10);

        if (vida <= 0)
        {
            vida = 0;

            if (Input.GetKeyDown(KeyCode.F1))
            {
                Reaparecer();
            }
        }
    }

    public void RecibirDaño(float daño)
    {
        vida -= daño;

        Debug.Log("PLAYER RECIBIO DAÑO - Vida: " + vida);

        if (vida <= 0)
        {
            vida = 0;
            Debug.Log("PLAYER MUERTO");
        }
    }

    void Reaparecer()
    {
        vida = 100;
        estamina = 10;

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        transform.position = posicionInicial;
        transform.rotation = rotacionInicial;

        Debug.Log("PLAYER REAPARECIO");
    }
}
