
using UnityEngine;

public class CambioCamara : MonoBehaviour
{
    public Vector3 posicionPrimeraPersona = new Vector3(0, 0.5f, 0);
    public Vector3 posicionTerceraPersona = new Vector3(0, 0.5f, -3);

    bool terceraPersona = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            terceraPersona = !terceraPersona;

            if (terceraPersona)
            {
                transform.localPosition = posicionTerceraPersona;
            }
            else
            {
                transform.localPosition = posicionPrimeraPersona;
            }
        }
    }
}
