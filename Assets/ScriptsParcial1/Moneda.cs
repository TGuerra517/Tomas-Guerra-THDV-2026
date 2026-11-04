
using UnityEngine;

public class Moneda : MonoBehaviour
{
    void OnTriggerEnter(Collider otro)
    {
        InventarioMonedas inventario = otro.GetComponent<InventarioMonedas>();

        if (inventario != null)
        {
            inventario.AgregarMoneda();
            Destroy(gameObject);
        }
    }
}

