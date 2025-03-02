using UnityEngine;
//Private: Dev can't change variable/input

public class TankMover : Mover // child
{
    // VARIABLES/INPUTS
    // Clones/Gets rigidbody and transform
    private Rigidbody rb;
    private Transform tf;

    //BLUEPRINTS
    public override void Start()
    {
        // Get the Rigidbody component/Automatically already input what part im controlling of the pawntank
        rb = GetComponent<Rigidbody>();  
        tf = GetComponent<Transform>();     
    }
    public override void Update()
    {
       
    }

    //VARIABLES
    public override void Move(Vector3 direction, float speed)
    {
        Vector3 moveVector = direction.normalized * speed * Time.deltaTime;
        rb.MovePosition(rb.position + moveVector);
    }

    public override void Rotate(float turnSpeed)
    {
        tf.Rotate(0,turnSpeed * Time.deltaTime, 0);

    }
}
