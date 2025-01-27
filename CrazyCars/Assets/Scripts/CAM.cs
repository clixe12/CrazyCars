using UnityEngine;

public class SimpleCarController : MonoBehaviour
{
    public float moveSpeed = 10f; // Velocidad de movimiento

    void Update()
    {
        // Mueve el coche hacia arriba en el eje Y
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;
    }
}