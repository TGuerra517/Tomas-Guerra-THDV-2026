using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (transform.position.x > 5f || transform.position.x < -5f)
        {
            speed = -speed;
        }
    }
}
