using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;    // Prefab de la moneda
    public float spawnRate = 2f;     // Tiempo en segundos entre cada aparición de moneda

    void Start()
    {
        // Iniciar la corrutina para generar monedas continuamente
        StartCoroutine(SpawnCoins());
    }

    // Corrutina para generar monedas
    IEnumerator SpawnCoins()
    {
        while (true)
        {
            // Obtener los límites de la cámara
            float screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize;
            float screenLeftEdge = -screenHalfWidthInWorldUnits;
            float screenRightEdge = screenHalfWidthInWorldUnits;

            // Generar una posición X aleatoria dentro de los límites de la cámara
            float randomX = Random.Range(screenLeftEdge, screenRightEdge);

            // Generar la moneda en la posición aleatoria
            Instantiate(coinPrefab, new Vector3(randomX, Camera.main.orthographicSize + 1, 0), Quaternion.identity);

            // Esperar un tiempo antes de generar la siguiente moneda
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
