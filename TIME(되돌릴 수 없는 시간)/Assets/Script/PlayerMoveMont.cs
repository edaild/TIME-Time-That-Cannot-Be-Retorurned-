using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMont : MonoBehaviour
{
    public float playerSpeed;
    public float jumpForce;
    public LayerMask groundLayer;
    public float groundCheckDistance = 0.1f;
    private bool isGrounded;

    private Rigidbody playerRigidbody;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 Movemont = new Vector3 (xInput, 0, zInput);

       playerRigidbody.velocity = Movemont * playerSpeed * Time.deltaTime;

        transform.LookAt(transform.position + Movemont);

        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        playerRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
