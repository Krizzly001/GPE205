using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    //VARIABLES
    public float damageDone;
    public Pawn owner; //Access to Pawns/tank attached to bullet




    //BLUEPRINTS
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    
    //Collider having access to the the object health being colided with the bullet

    public void OnTriggerEnter(Collider other)
    {
        //Stores the objects health thats being attacked into otherHealth
        Health otherHealth = other.gameObject.GetComponent<Health>();

        //Check if health component exist...
        if(otherHealth != null)
        {
            //(Damaged being done to the object, who damaged the object)
            otherHealth.TakeDamage(damageDone, owner);
        }
        Destroy(gameObject);//Destroys bullet
    }


    //FUNCTIONS



}
