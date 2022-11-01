using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float groundDrag;


    Rigidbody rb;
    public Transform orientation;
    float horizontalInput;
    float verticalInput;
    public float speed;

    Vector3 moveDirection;






    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void MovementInput()
    {
        //player movement
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");


    }

    // Update is called once per frame
    void Update()
    {
        MovementInput();
        rb.drag = groundDrag;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        //calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirection.normalized * speed, ForceMode.Force);
    }
}
