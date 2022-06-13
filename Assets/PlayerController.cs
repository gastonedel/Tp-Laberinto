using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed;
    public float rotationSpeed;
    private Rigidbody rb;
    public float jumpHeight = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0, 0, movementSpeed);
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.position -= new Vector3(0, 0, movementSpeed);
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (IsGrounded() && Input.GetKey(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jumpHeight;
        }

        if (transform.position.y < 0)
        {
            SceneManager.LoadScene("Derrota");
        }
    }
    public bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.0f);
    }

  
}
