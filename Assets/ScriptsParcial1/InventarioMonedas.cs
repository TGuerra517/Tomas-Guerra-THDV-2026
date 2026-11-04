
using UnityEngine;

public class InventarioMonedas : MonoBehaviour
{
    public int[] monedas = new int[5];
    public int cantidadMonedas = 0;

    public void AgregarMoneda()
    {
        if (cantidadMonedas < monedas.Length)
        {
            monedas[cantidadMonedas] = 1;
            cantidadMonedas++;

            Debug.Log("Moneda recogida");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("MONEDAS TOTALES EN INVENTARIO: " + cantidadMonedas);
        }
    }
}
