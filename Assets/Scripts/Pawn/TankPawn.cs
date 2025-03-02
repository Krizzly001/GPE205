using UnityEngine;

public class TankPawn : Pawn
{
    // Start is called before the first frame update
    public override void Start()
    {
         mover = GetComponent<Mover>();
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

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
