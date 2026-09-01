using UnityEngine;


public class RotatingObject : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0f, 50f * Time.deltaTime, 0f);
    }
}