using UnityEngine;
using UnityEngine.SceneManagement; // Esto permite recargar la escena o ir a una escena de Game Over

public class ScreenBounds : MonoBehaviour
{
    private float screenHalfWidthInWorldUnits;
    private float screenHalfHeightInWorldUnits;

    // Start se llama una vez al inicio
    void Start()
    {
        // Calcular los límites de la pantalla en unidades del mundo
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize;
        screenHalfHeightInWorldUnits = Camera.main.orthographicSize;
    }

    // Update se llama una vez por frame
    void Update()
    {
        // Obtener la posición actual del jugador
        Vector3 playerPosition = transform.position;

        // Verificar si el jugador se sale de los límites de la pantalla
        if (playerPosition.x < -screenHalfWidthInWorldUnits || playerPosition.x > screenHalfWidthInWorldUnits ||
            playerPosition.y < -screenHalfHeightInWorldUnits || playerPosition.y > screenHalfHeightInWorldUnits)
        {
            // Si el jugador toca el borde de la pantalla, activamos el Game Over
            GameOver();
        }
    }

    // Método que se ejecuta cuando el jugador toca el borde de la pantalla
    void GameOver()
    {
        Debug.Log("Game Over! El jugador tocó el borde de la pantalla.");
        
        // Aquí puedes cambiar la lógica del Game Over según lo que necesites
        // Por ejemplo, recargar la escena o ir a una escena específica de Game Over

        // Recargar la escena actual para reiniciar el juego (opcional)
        SceneManager.LoadScene("GameOverScene");

        // Alternativamente, puedes cargar una escena de "Game Over" si tienes una
        // SceneManager.LoadScene("GameOverScene");
    }
}
