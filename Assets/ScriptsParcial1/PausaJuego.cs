
using UnityEngine;

public class PausaJuego : MonoBehaviour
{
    bool pausado = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausado = !pausado;

            if (pausado)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }

    void OnDisable()
    {
        Time.timeScale = 1f;
    }
}

