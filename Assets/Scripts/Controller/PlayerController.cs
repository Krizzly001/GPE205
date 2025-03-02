using UnityEngine;

public class PlayerController : Controller
{
    //VARIABLES: dev inputs which key to use
    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterClockwiseKey;

    //BLUEPRINTS
    public override void Start()
    {
        // Run the Start() function from the parent (base) class
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {   
        // Process our Keyboard Inputs
        ProcessInputs();

        // Run the Update() function from the parent (base) class
        base.Update();        
    }

    //FUNCTIONS

    public override void ProcessInputs()
    {
        if (Input.GetKey(moveForwardKey)) 
        {
            pawn.MoveForward();
        }

        if (Input.GetKey(moveBackwardKey)) 
        {
            pawn.MoveBackward();
        }

        if (Input.GetKey(rotateClockwiseKey)) 
        {
            pawn.RotateClockwise();
        }

        if (Input.GetKey(rotateCounterClockwiseKey)) 
        {
            pawn.RotateCounterClockwise();
        }
    }
}
