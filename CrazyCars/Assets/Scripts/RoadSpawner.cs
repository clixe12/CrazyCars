using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public GameObject roadPrefab; // Prefab de la carretera
    public float roadLength = 10f; // Longitud de cada segmento de carretera
    public float spawnInterval = 5f; // Intervalo de tiempo en segundos para crear una nueva carretera

    private float lastRoadPositionY; // Posición Y del último segmento creado

    void Start()
    {
        lastRoadPositionY = 0f; // Comienza en la posición inicial (Y = 0 o donde desees)
        InvokeRepeating("SpawnRoadSegment", 0f, spawnInterval); // Crea un nuevo segmento cada 5 segundos
    }

    void SpawnRoadSegment()
    {
        // Instanciamos un nuevo segmento de la carretera encima del anterior
        Instantiate(roadPrefab, new Vector3(0, lastRoadPositionY, 0), Quaternion.identity);

        // Actualizamos la última posición Y donde se generó un segmento
        lastRoadPositionY += roadLength; // Asegura que cada segmento se coloque arriba del anterior
    }
}
