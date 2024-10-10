using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Referencia al componente Rigidbody2D
    }

    void Update()
    {
        // Obtener las entradas del jugador para los ejes X e Y
        float moveX = Input.GetAxis("Horizontal"); // Movimiento horizontal (flechas o teclas A y D)
        float moveY = Input.GetAxis("Vertical");   // Movimiento vertical (flechas o teclas W y S)

        // Aplicar el movimiento en el Rigidbody2D
        rb.velocity = new Vector2(moveX * speed, moveY * speed);
    }
}
