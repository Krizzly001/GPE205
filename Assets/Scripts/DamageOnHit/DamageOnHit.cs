using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    //VARIABLES
    public float damageDone; //Damage being done
    public Pawn owner; //Tank owner

    //BLUEPRINTS
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    //FUNCTIONS

    public void OnTriggerEnter(Collider other)
    {
        Health otherHealth = other.gameObject.GetComponent<Health>();

        if(otherHealth != null)
        {
            otherHealth.TakeDamage(damageDone, owner);
        }
        
        //Detroys bullet
        Destroy(gameObject);
        
    }
}
