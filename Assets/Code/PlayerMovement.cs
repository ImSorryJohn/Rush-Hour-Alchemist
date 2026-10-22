using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float movSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    //public VisualEffect vfxRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * movSpeed;
        speedY = Input.GetAxisRaw("Vertical") * movSpeed;
        
        //vfxRenderer.SetVector3("ColliderPos", transform.position);

    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
