using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        //gets a refrence from rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        //this code take the movement value and store it to a vector 2 variable(movemenvector)
        Vector2 movementVector = movementValue.Get<Vector2> ();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }
}
