using UnityEngine;

public class TankPawn : Pawn // child
{
    private float timerDelay;
    private float nextShootTime;
    //BLUEPRINTS
    public override void Start()
    {
        timerDelay = 1 / fireRate;

        nextShootTime = Time.time + nextShootTime;
        //Variable inisalize
        base.Start();
    }
    public override void Update()
    {
        base.Update();
 
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

    public override void Shoot()
    {
        if (Time.time >= nextShootTime)
        {
            shooter.Shoot(shellPrefab, fireForce, damageDone, shellLifespan);
            nextShootTime = Time.time + timerDelay;

        }
        
    }


}
