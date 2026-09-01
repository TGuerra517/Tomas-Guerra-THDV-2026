using UnityEngine;

public class PruebaClase2 : MonoBehaviour
{
    int edad = 25;
    int nacimiento = 110900;
    string nombre = "Tomas";
    void Start()
    {
        Debug.Log("hola");
    }

   
    void Update()
    {
        Debug.Log("" + nombre + "" + edad + "" + nacimiento);
    }
}
