using UnityEngine;

public class PlayerController : Controller
{
    //VARIABLES: dev inputs which key to use
    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterClockwiseKey;

    public KeyCode shootKey;

    //BLUEPRINTS
    public override void Start()
    {
        if(GameManager.instance != null) //if my gameinstance exists
        {
            if(GameManager.instance.players != null) // and if list exists
            {
                GameManager.instance.players.Add(this); // add a player to my list of players

            }
        }
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
        //Get Key: keeps going on hold
        //Get Key Down: Being used down
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
        if (Input.GetKeyDown(shootKey))
        {
            pawn.Shoot();
        }

    }
}
