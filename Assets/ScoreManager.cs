using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // El campo de UI que muestra la puntuación en pantalla
    private int score = 0;  // La puntuación actual del jugador

    // Método para añadir puntos
    public void AddScore(int value)
    {
        score += value;  // Aumenta la puntuación
        UpdateScoreText();  // Actualiza el texto en pantalla
    }

    // Método para actualizar el texto de puntuación
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
