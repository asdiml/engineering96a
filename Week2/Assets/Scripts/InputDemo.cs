using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class InputDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue value)
    {
        Vector2 v = value.Get<Vector2>();
        
        transform.position += new Vector3(v.x, 0, v.y);
    }

    void OnFire()
    {

    }

    void OnJump()
    {
        Debug.Log("I jumped!");
    }
}

