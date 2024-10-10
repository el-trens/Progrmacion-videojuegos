using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar de escena

public class GameOverManager : MonoBehaviour
{
    public void RestartGame()
    {
        Debug.Log("Botón presionado: Reiniciando el juego.");
        // Recargar la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
