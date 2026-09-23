using UnityEngine;

public class TopDownPlayerMovement : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        float movimientoX = Input.GetAxis("Horizontal");
        float movimientoZ = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoX, 0, movimientoZ);

        transform.position += movimiento * velocidad * Time.deltaTime;
    }
}