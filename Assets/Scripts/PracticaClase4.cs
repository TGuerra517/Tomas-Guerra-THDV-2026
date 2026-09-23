using System;
using UnityEngine;

public class PracticaClase4 : MonoBehaviour
{

    // Este cs esta comentado de tal manera para que se pueda ir probando ejercicio por ejercicio
    // eso si, entender el orden de ejecucion para saber que descomentar o no
    // Ejemplo: no pueden haber dos Updates()

    int segundos = 0;
    float tiempo = 0;
    int duracion = 10;
    bool terminado = false;
    int segundosRestantes = 10;
    int[] segundosPares = new int[5];
    int posicionArray = 0;
    
    

    // EJERCICIO N1: Contador de segundos
    // Crear un timer que comience en 0 y muestre en la consola un mensaje cada vez que trascurra un segundo
    // El resultado deberia ser: segundo: 1, segundo: 2.... indefinidiamente


    /*void Update() 
    {
        
        tiempo += Time.deltaTime;

        if (tiempo >= 1)
        {
            segundos++;
            
            Debug.Log("Segundo: " + segundos); 
            
            tiempo = 0;

        }

    }*/


    // EJERCICIO N2: Timer con duración
    // Modificar el timer anterior para que tenga una duración determinada.
    // La duración debe almacenarse en una variable: int duracion = 10;
    // El timer debe detenerse cuando llegue a esa cantidad de segundos.
    // Agregar un mensaje solamente cuando termine

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

    }*/


    // EJERCICIO N3: Pasar el timer a un método
    // Modificar el ejercicio anterior para que el timer sea ejecutado mediante un método

    void Update()
    {
        LogicaTimer();
        //MostrarPares();
        //LogicaCuentaRegresiva();
        //LogicaTimerPar();
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

                //Instruccion que hice yo
                if (segundos % 2 == 0) //Agregado para ejercicio 5
                {
                    //Instruccion que hice yo
                   Debug.Log("Segundo: " + segundos + " Numero Par ");
                    GuardarNumeroPar(); //Agregado para ejercicio 6

                    //Debug.Log("Segundo: " + segundos + "Par");

                    //else
                    //Debug.Log("Segundo: " + segundos)

                }
           
                if (segundos >= duracion)
                {
                    terminado = true;

                    Debug.Log("Timer terminado");
                    MostrarPares();
                }

            }
        }
    }

    // EJERCICIO N4: Cuenta regresiva
    // Crear un metodo de un timer que funcione como cuenta regresiva.
    // Si la duracion es 10 debe mostrar: Tiempo restante: 10, Tiempo restante: 9... Hasta llegar a 0, y enunciar que termino
    
    void LogicaCuentaRegresiva()
    {
        if (!terminado)
        {
            tiempo += Time.deltaTime;

            if (tiempo >= 1)
            {
                segundosRestantes--;
                
                Debug.Log("Tiempo restante: " + segundosRestantes); 
                
                tiempo = 0;

                if (segundosRestantes <= 0)
                {
                    terminado = true;

                    Debug.Log("Timer terminado"); 
                }

            }
        }
    }

    //Metodo Ejercicio 6
    void GuardarNumeroPar()
    {
        segundosPares[posicionArray] = segundos;
        posicionArray++;
    }

    //Metodo Ejercicio 6
    void MostrarPares()
    {

        for (int i = 0; i < segundosPares.Length; i++)
        {
            Debug.Log("Par: " + segundosPares[i]);

        }
    }
        //}
        // EJERCICIO N5: Detectar segundos pares
        //Hacer un metodo basado en LogicaTimer() para indicar si el segundo actual es par
        //Esta indicacion la hacemos por mensaje de consola

        //Agregue una istruccion al metodo void LogicaTimer, por eso no pongo un nuevo codigo aca.


        // EJERCICIO N6: Guardar los numeros pares y mostrarlo.
        //Modificamos LogicaTimer() para que guarde los segundos pares.
        //Esto lo hacemos usando arrays, que es una estructura de datos para almacenar una coleccion de elementos del mismo tipo. 
        //Avanzamos por el usando un indice y para mostrar lo que tiene el arreglo utilzamos un for. Solo lo mostramos al final.

        //Ejercicio N7: Buscar valores con while
        //Crear un nuevo metodo que en vez de utilizar un for utilice un while
        //y solamente mostrar los valores mayores de 5 de la lista de los pares

       // void MostrarParesMayoresWhile()

        //{
          //  int index = 0;
            //while (index < segundosPares.Length)
            //{ if (segundosPares[index]) >= 5)
              //          Debug.Log("Par: " + segundosPares[index]);
                //index++;
          //  }
        //}
    }


