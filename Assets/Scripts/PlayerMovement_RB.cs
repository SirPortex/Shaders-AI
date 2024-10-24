using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_RB : MonoBehaviour
{
    public float walkingSpeed, runningSpeed, aceleration, rotationSpeed, jumpForce, sphereRadius;//,gravityScale;


    public string groundName;

    private Animator animator;

    private Vector3 movementVector;

    private Rigidbody rb;
    private float x, z, mouseX; //input
    private bool jumpPressed;
    private bool shiftPressed;
    private float currentSpeed;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

        //gravityScale = -Mathf.Abs(gravityScale); //Valor Absoluto

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
        mouseX = Input.GetAxisRaw("Mouse X");
        shiftPressed = Input.GetKey(KeyCode.LeftShift);

        InterpolationSpeed();


        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            jumpPressed = true;
        }
        //jump

        RotatePlayer();
    }

    public void InterpolationSpeed()
    {
        if (shiftPressed)
        {
            currentSpeed = Mathf.Lerp(currentSpeed, runningSpeed, aceleration * Time.deltaTime);
        }
        else if (x != 0 || z != 0)
        {
            currentSpeed = Mathf.Lerp(currentSpeed, walkingSpeed, aceleration * Time.deltaTime);
        }
        else
        {
            currentSpeed = Mathf.Lerp(currentSpeed, 0, aceleration * Time.deltaTime);
        }
    }

    void RotatePlayer()
    {
        Vector3 rotation = new Vector3(0, mouseX, 0) * rotationSpeed * Time.deltaTime;
        transform.Rotate(rotation); // Se aplica la rotacion, tiene numero imaginarios
    }
    private void FixedUpdate()
    {
        ApplySpeed();
        ApplyJumpSpeed();


    }

    void ApplySpeed()
    {
        rb.velocity = (transform.forward * currentSpeed * z) + (transform.right * currentSpeed * x) +
            new Vector3(0, rb.velocity.y, 0); //Gravedad base de Unity.
        //+ (transform.up * gravityScale); //Gravedad constante no realista
        //rb.AddForce(transform.up * gravityScale);
    }

    void ApplyJumpSpeed()
    {
        if (jumpPressed)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(transform.up * jumpForce);
            jumpPressed = false;
        }
    }

    private bool IsGrounded()
    {
        Collider[] colliders = Physics.OverlapSphere(new Vector3(transform.position.x,
            transform.position.y  - transform.localScale.y / 20, transform.position.z), sphereRadius);

        for (int i = 0; i < colliders.Length; i++) //recorremos elemento a elemento.
        {
            // y comprobamos si el elemento es suelo o no.
            if (colliders[i].gameObject.layer == LayerMask.NameToLayer(groundName)) //Recorre cada elemento del array para ver si tocamos suelo
            {
                return true;
            }
        }

        return false;
    }

    private void OnDrawGizmos() //Raycast de la esfera.
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(new Vector3(transform.position.x,
            transform.position.y - transform.localScale.y / 20, transform.position.z), sphereRadius);
    }

    public float GetCurrentSpeed()
    {
        return currentSpeed;
        
    }

    
}
