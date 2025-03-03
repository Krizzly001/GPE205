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

    public override void RotateTowards(Vector3 targetPosition)
    {
        // Find the vector to our target
        Vector3 vectorToTarget = targetPosition - transform.position;
        // Find the rotation to look down that vector
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);
        // Rotate closer to that vector, but don't rotate more than our turn speed allows in one frame
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }

    public override void RotateAway(Vector3 targetPosition)
    {
        // Find the vector to our target and reverse it to rotate away
        Vector3 vectorAwayFromTarget = transform.position - targetPosition; 

        // Find the rotation to look down that vector
        Quaternion targetRotation = Quaternion.LookRotation(vectorAwayFromTarget, Vector3.up);

        // Rotate closer to that vector, but don't rotate more than our turn speed allows in one frame
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }

    public override void MakeNoise()
    {
        if (noiseMaker != null)
        {
            noiseMaker.volumeDistance = noiseMakerVolume;
        }

    }
    public override void StopNoise()
    {
        if (noiseMaker != null)
        {
            noiseMaker.volumeDistance = 0;
        }

    }


}
