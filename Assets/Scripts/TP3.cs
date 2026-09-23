using System;
using System.Runtime.ConstrainedExecution;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using static UnityEngine.Audio.ProcessorInstance.AvailableData;

public class TP3 : MonoBehaviour
{
    // EJERCICIO N1: Contador de segundos
    //Crear un timer que comience en 0 y muestre en la consola un mensaje cada vez que trascurra un segundo.
    //El resultado debería ser: segundo: 1, segundo: 2.... indefinidamente

    float tiempo = 0;
    int segundos = 0;


    /*void Update()
     {
         tiempo += Time.deltaTime;
         if (tiempo >= 1)
         {
             segundos++;
             Debug.Log("segundo " + segundos);
             tiempo = 0;
         }
    */

    // EJERCICIO N2: Timer con duración
    //Modificar el timer anterior para que tenga una duración determinada.La duración debe almacenarse en una variable: int duracion = 10;
    //El timer debe detenerse cuando llegue a esa cantidad de segundos.Agregar un mensaje solamente cuando termine.


    int duracion = 10;
    bool terminado = false;


    /*void Update()
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

                    Debug.Log("Timer terminado");
                }

            }
        }


    }

    */
    //EJERCICIO N3: Pasar el timer a un método.
    //Modificar el ejercicio anterior para que el timer sea ejecutado mediante un método

    void Update()
    {
        LogicaTimer();
        //cuentaregresiva();
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

                if (segundos % 2 == 0)
                {
                    Debug.Log("Segundo Par");
                }

                if (segundos >= duracion)
                {
                    terminado = true;

                    Debug.Log("Timer terminado");
                }

            }
        }
    }


    //EJERCICIO N4: Cuenta regresiva
    //Crear un método de un timer que funcione como cuenta regresiva.Si la duración es 10 debe mostrar: Tiempo restante: 10, Tiempo restante: 9... Hasta llegar a 0, y enunciar que termino

    int tiemporestante = 10;

    void cuentaregresiva()
    {
        if (!terminado) 
        {
        tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                tiemporestante--;
                Debug.Log ("Tiempo Restante: " +  tiemporestante);
                tiempo = 0;
            }


            if (tiemporestante ==  0)
            {
                terminado = true;
                Debug.Log("Tiempo cumplido");
            }
        }
    }


    // EJERCICIO N5: Detectar segundos pares
    //Hacer un método basado en LogicaTimer() para indicar si el segundo actual es par.Esta indicacion la hacemos por mensaje de consola.



    //EJERCICIO N6: Guardar los segundos pares y mostrarlo
    //Modificamos LogicaTimerPar() para que guarde los segundos pares,
    //Esto lo hacemos usando arrays, que es una estructura de datos para almacenar una colección de elementos del mismo tipo.Avanzamos por el usando un indice.Y para mostrar lo que tiene el arreglo utilizamos un for. Solo lo mostramos al final.
}









