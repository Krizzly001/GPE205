using UnityEngine;

public class TankMover : Mover
{
    //VARIABLES
    private Rigidbody rb; // Hold the rigidbody component
    private Transform tf;


    //BLUEPRINTS
    public override void Start()
    {
        
        //Grabs rigidbody and stors it in rb
        rb = GetComponent<Rigidbody>();
        //pawns transform is stored in tf
        tf = GetComponent<Transform>();
        
    }
    public override void Update()
    {
       
        
    }

    //FUNCTIONS
    public override void Move(Vector3 direction, float speed)
    {
        //Gets Vector3 direction and makes it to unit 1
        //Multiply by speed
        //Time.deltaTime: Updates frame drop by the speed of user computer
        Vector3 moveVector = direction.normalized * speed * Time.deltaTime;


        //(Gets current rb position the tanks position + the direction itll move)
        rb.MovePosition(rb.position + moveVector);

    }
    public override void Rotate(float turnSpeed)
    {
        tf.Rotate(0, turnSpeed * Time.deltaTime, 0);


    }
}
