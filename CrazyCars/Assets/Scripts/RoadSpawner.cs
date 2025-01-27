using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public GameObject roadPrefab; // Prefab de la carretera
    public GameObject bushPrefab; // Prefab del arbusto
    public float roadLength = 10f; // Longitud de cada segmento de carretera
    public float spawnInterval = 5f; // Intervalo de tiempo en segundos para crear una nueva carretera
    public float bushSpawnRangeX = 5f; // Rango en el eje X para la posición del arbusto
    public float bushSpawnInterval = 2f; // Intervalo de tiempo para crear un arbusto en cada lado de la carretera

    private float lastRoadPositionY; // Posición Y del último segmento creado

    void Start()
    {
        lastRoadPositionY = 0f; // Comienza en la posición inicial (Y = 0 o donde desees)
        InvokeRepeating("SpawnRoadSegment", 0f, spawnInterval); // Crea un nuevo segmento cada X segundos
    }

    void SpawnRoadSegment()
    {
        // Instanciamos un nuevo segmento de la carretera encima del anterior
        Instantiate(roadPrefab, new Vector3(0, lastRoadPositionY, 0), Quaternion.identity);

        // Actualizamos la última posición Y donde se generó un segmento
        lastRoadPositionY += roadLength; // Asegura que cada segmento se coloque arriba del anterior

        // Llamamos a la función para crear arbustos
        SpawnBushes();
    }

    void SpawnBushes()
    {
        // Crea arbustos en posiciones aleatorias a los lados de la carretera

        // Crea un arbusto en el lado izquierdo de la carretera
        float bushPosXLeft = Random.Range(-bushSpawnRangeX, -1f); // Posición aleatoria en el eje X
        Vector3 bushPosLeft = new Vector3(bushPosXLeft, lastRoadPositionY, 0); // Usamos la posición de la carretera
        Instantiate(bushPrefab, bushPosLeft, Quaternion.identity);

        // Crea un arbusto en el lado derecho de la carretera
        float bushPosXRight = Random.Range(1f, bushSpawnRangeX); // Posición aleatoria en el eje X
        Vector3 bushPosRight = new Vector3(bushPosXRight, lastRoadPositionY, 0); // Usamos la posición de la carretera
        Instantiate(bushPrefab, bushPosRight, Quaternion.identity);
    }
}
