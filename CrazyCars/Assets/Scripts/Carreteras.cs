using UnityEngine;

public class RoadSegment : MonoBehaviour
{
    public float lifetime = 10f; // Tiempo en segundos que el segmento vivirá antes de desaparecer

    void Start()
    {
        // Destruir este segmento después de 'lifetime' segundos
        Destroy(gameObject, lifetime);
    }
}
