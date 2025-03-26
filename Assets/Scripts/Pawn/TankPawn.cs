using UnityEngine;

public class TankPawn : Pawn // Child of Pawn
{
    
    //VARIABLES
    //Eveytime we shoot we want to delay the next time we are allowed to shoot again
    private float nextShootTime;

    private float timerDelay;
    




    //BLUEPRINTS
   
    public override void Start()
    {
        //fireRate variable in are Parent class
        timerDelay = 1/fireRate;
        // ex. fireRate = 3
        // my tank is capable of firing 3 bullets per 1 second
        //Higher the fireRate is the faster bullets spawn and shoot

        //calculated the time im allowed to shoot(future time) = current time + time I wanna to shoot next later
        nextShootTime = Time.time + nextShootTime;
        
        base.Start();//Calls parents start()
    }

    
    public override void Update()
    {
        base.Update();
    }


    //FUNCTIONS

    //Override: Change information from the parent function
    //Transform: unit vector ahead of the game object
    public override void MoveFoward()
    {
        storeMover.Move(transform.forward, moveSpeed);

    }
    public override void MoveBackward()
    {
        storeMover.Move(transform.forward, -moveSpeed);//-Opposite direction

    }
    public override void RotateClockwise()
    {
        storeMover.Rotate(turnSpeed);

    }
    public override void RotateCounterClockwise()
    {
        storeMover.Rotate(-turnSpeed);

    }
    public override void Shoot()
    {
        if(Time.time >= nextShootTime) //if its time to shoot -> shoot
        {
            //place into the shooter and fires
            storeShooter.Shoot(shellPrefab, fireForce, damageDone, shelllifespan);
            
            //update my next shoot time im allowed so we arent spamming
            // delays my next shootTime
            nextShootTime = Time.time + timerDelay;
        }
        
    }

    public override void RotateTowards(Vector3 targetPosition)
    {
        // Find the vector to our users tank
        Vector3 vectorToTarget = targetPosition - transform.position;
        // Find the rotation to look down that vector
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);
        // Rotate closer to that vector, but don't rotate more than our turn speed allows in one frame
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);

    }
    public override void RotateAway(Vector3 targetPosition)
    {
        // Find the vector to our users tank
        Vector3 vectorToTarget = targetPosition - transform.position;
        // Find the rotation to look down that vector
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);
        // Rotate closer to that vector, but don't rotate more than our turn speed allows in one frame
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, -turnSpeed * Time.deltaTime);

    }



}
