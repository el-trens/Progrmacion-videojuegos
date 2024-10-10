using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private AudioSource audioSource;
    private bool hasCollided = false;

    void Start()
    {
        // Obtener el componente AudioSource del obstáculo
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasCollided)
        {
            hasCollided = true;  // Evitar que el sonido se reproduzca más de una vez
            
            // Reproducir el sonido al tocar el obstáculo
            audioSource.Play();

            // Aquí puedes agregar lógica adicional, como dañar al jugador o hacer un Game Over
            // Por ejemplo, destruir el jugador o mostrar una pantalla de Game Over:
            // Destroy(collision.gameObject);

            // Si el obstáculo se destruye después de la colisión, puedes destruirlo después del sonido
            Destroy(gameObject, audioSource.clip.length); // Destruye el obstáculo después de que termine el sonido
        }
    }
}
