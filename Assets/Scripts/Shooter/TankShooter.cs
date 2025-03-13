using UnityEngine;

public class TankShooter : Shooter
{
    //VARIABLES
    //get transform(location/rotation) of the exact bullet prefab
    public Transform firepointTransform; //input

    //BLUEPRINTS
    public override void Start()
    {
        
    }
    public override void Update()
    {
        
    }

    //FUNCTIONS
    public override void Shoot(GameObject shellPrefab, float fireForce, float damageDone, float lifespan)
    {
        //bullet info skin and location/roatation
        GameObject newshell = Instantiate(shellPrefab, firepointTransform.position, firepointTransform.rotation);
        
        //assigning the damage being done, from damageOnHit script
        DamageOnHit doh = newshell.GetComponent<DamageOnHit>();

        if(doh != null) //if doh has a value...
        {
            //DamageOnHit doh = Shoot(float damageDone)
            doh.damageDone = damageDone;

            //get the tank/Pawn assign it as the shooter owner
            //owner is in DamageOnHit, the point here is to pre-assign its owner
            doh.owner = GetComponent<Pawn>();
        }
        //Getting bullets rigidbody to delete
        Rigidbody rb = newshell.GetComponent<Rigidbody>();

        //Checl if thid bullet has a rigidbody
        if(rb != null)//if rb exists...
        {
            //AddForce so that is can move
            // making variable move foward by its force amount
            rb.AddForce(firepointTransform.forward * fireForce);
        }

        //Once its been launched...
        Destroy(newshell, lifespan);
        
        
    
    }   
}
