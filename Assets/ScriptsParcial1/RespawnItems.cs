
using System.Collections;
using UnityEngine;

public class RespawnItems : MonoBehaviour
{
    public GameObject prefabItem;
    public Transform[] puntosSpawn;
    public float tiempoRespawn = 2f;

    void Start()
    {
        StartCoroutine(ControlarItems());
    }

    IEnumerator ControlarItems()
    {
        while (true)
        {
            int cantidad = 0;

            foreach (Transform punto in puntosSpawn)
            {
                if (punto.childCount > 0)
                {
                    cantidad++;
                }
            }

            if (cantidad < 3)
            {
                foreach (Transform punto in puntosSpawn)
                {
                    if (punto.childCount == 0)
                    {
                        Instantiate(prefabItem, punto.position, punto.rotation, punto);

                        yield return new WaitForSeconds(tiempoRespawn);
                    }
                }
            }

            yield return null;
        }
    }
}
