using System.Collections;
using UnityEngine;

public class EjercicioTimer : MonoBehaviour

//Ejericicio 4: cuenta regresiva
//crear un metodo de un timer que funcione como cuenta regresiva
//si la duracion es de 10 se debe mostrar: tiempo restante: 10, tiempo restante: 9 hasta llegar a 0 y anunciar que termino
{
    float tiempo = 0;
    private int segundos = 0;
    private bool terminado = false;
    private int duracion = 10;

    void Update()
    {
        LogicaTimer();
    }

    void LogicaTimer()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundos++;
                Debug.Log("Segundo: " + segundos);
                tiempo = 0;

                if (segundos >= duracion)
                {
                    terminado = true;
                    Debug.Log("Timer Terminado");
                }
            }
        }
    } 

    void LogicaCuentaRegresiva()
    {
        


    }
}