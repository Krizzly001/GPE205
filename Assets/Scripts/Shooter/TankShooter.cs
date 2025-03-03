using UnityEngine;

public class TankShooter : Shooter
{
    //VARIABLES
    public Transform firepointTransform; //Gets Owners Transform



    //BLUEPRINTS
    public override void Start()
    {
        
    }
    public override void Update()
    {
        
    }

    //FUNCTIONS
    public override void Shoot(GameObject shellPrefab, float fireForce, float damageDone, float lifeSpan)
    {
        //Creat new bullet(object bullet being spawned, spawned at position, set rotation)
        GameObject newShell = Instantiate(shellPrefab, firepointTransform.position, firepointTransform.rotation);
        // Create a DamageOnHit on are newshell
        DamageOnHit doh = newShell.GetComponent<DamageOnHit>();

        if(doh != null) //Does not have a value
        {
            doh.damageDone = damageDone;
            doh.owner = GetComponent<Pawn>();
        }
        Rigidbody rb = newShell.GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.AddForce(firepointTransform.forward * fireForce);
        }

        Destroy(newShell, lifeSpan);
    }
}
