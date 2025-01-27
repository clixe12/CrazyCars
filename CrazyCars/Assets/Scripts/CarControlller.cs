using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 10f; // Velocidad de movimiento

    void Update()
    {
        // Obtener las entradas de las teclas A y D
        float moveHorizontal = 0f;

        if (Input.GetKey("a"))
        {
            moveHorizontal = -1f; // Mover a la izquierda
        }
        else if (Input.GetKey("d"))
        {
            moveHorizontal = 1f; // Mover a la derecha
        }
        // Mueve el coche hacia arriba en el eje Y
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;


        // Mueve el coche en el eje X (izquierda/derecha)
        transform.position += new Vector3(moveHorizontal * moveSpeed * Time.deltaTime, 0f, 0f);
    }
}