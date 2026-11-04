
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public float rango = 20f;
    public float daño = 25f;
    public float cadencia = 1.5f;
    public int balas = 10;

    public Camera camara;

    float tiempoUltimoDisparo;
    PlayerStats stats;

    void Start()
    {
        stats = GetComponent<PlayerStats>();
    }

    void Update()
    {

        if (Time.timeScale == 0f)
        {
            return;
        }

        if (stats.vida <= 0)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0) && balas > 0 &&
            Time.time >= tiempoUltimoDisparo + cadencia)
        {
            Disparar();
        }
    }

    void Disparar()
    {
        balas--;
        tiempoUltimoDisparo = Time.time;

        Debug.Log("DISPARO - Balas restantes: " + balas);

        RaycastHit hit;

        int capasPermitidas = ~LayerMask.GetMask("Player");

        if (Physics.Raycast(camara.transform.position,
                            camara.transform.forward,
                            out hit,
                            rango,
                            capasPermitidas))
        {
            Debug.Log("Raycast golpeo: " + hit.collider.name);

            EnemyStats enemigo = hit.collider.GetComponent<EnemyStats>();

            if (enemigo != null)
            {
                enemigo.RecibirDaño(daño);
            }
        }
    }
}

