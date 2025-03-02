using UnityEngine;

public class TankPawn : Pawn // child
{
    //BLUEPRINTS
    public override void Start()
    {
         mover = GetComponent<Mover>(); // Uses Mover component script 
    }
    public override void Update()
    {
 
    }

    //FUNCTIONS
    // Uses Mover functions

    public override void MoveForward()
    {
        mover.Move(transform.forward, moveSpeed);
        
    }

    public override void MoveBackward()
    {
        mover.Move(transform.forward, -moveSpeed);
        
    }

    public override void RotateClockwise()
    {
        mover.Rotate(turnSpeed);
        
    }

    public override void RotateCounterClockwise()
    {
        mover.Rotate(-turnSpeed);
    }
}
