using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isCollected = false;
    private ScoreManager scoreManager;

    void Start()
    {
        // Obtener el componente AudioSource de la moneda
        audioSource = GetComponent<AudioSource>();
        
        // Buscar el ScoreManager en la escena
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            isCollected = true;  // Evitar que se recoja más de una vez

            // Reproducir el sonido al recoger la moneda
            audioSource.Play();

            // Añadir puntos a la puntuación
            scoreManager.AddScore(1); // Aquí se aumenta la puntuación

            // Desactivar el sprite y collider para que desaparezca de la vista
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;

            // Destruir la moneda después de que el sonido termine de reproducirse
            Destroy(gameObject, audioSource.clip.length);
        }
    }
}
