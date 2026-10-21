using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensibilidad = 2f;
    public Transform jugador;

    float rotacionVertical = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidad;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidad;

        jugador.Rotate(Vector3.up * mouseX);

        rotacionVertical -= mouseY;
        rotacionVertical = Mathf.Clamp(rotacionVertical, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotacionVertical, 0f, 0f);
    }
}