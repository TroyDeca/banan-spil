using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 velocity;


    private void Start()
    {

    }

    private void Update()
    {
        velocity = Vector2.zero;
        velocity = velocity.normalized * Time.deltaTime;
        velocity.x = Input.GetAxisRaw("Horizontal");
        velocity.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * moveSpeed * Time.fixedDeltaTime);
    }

}
