using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerScript : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX,movementY;
    public float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        Debug.Log(movementVector);

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void FixedUpdate()
    {   
        if(rb==null) Debug.Log("Fuck");
        
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement*speed);
    }
}
