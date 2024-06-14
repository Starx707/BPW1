using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float MovementSpeed = 5f;
    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    private SpriteRenderer MySpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        MySpriteRenderer = GetComponent<SpriteRenderer>(); //To change the sprite while moving
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * MovementSpeed * Time.fixedDeltaTime); //Character movement with sprite change

        if (movement.x == -1)
        {
            MySpriteRenderer.flipX = true;
        }
        if (movement.x == 1)
        {
            MySpriteRenderer.flipX = false;
        }

    }
}
