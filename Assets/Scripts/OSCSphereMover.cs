using UnityEngine;

public class OscSphereMover : MonoBehaviour
{
    public float radius = 2.0f;
    public float speed = 1.0f;

    void Update()
    {
        float t = Time.time * speed;
        float x = Mathf.Sin(t) * radius;
        float y = 1.7f;
        float z = Mathf.Cos(t) * radius;

        transform.position = new Vector3(x, y, z);
    }
}
