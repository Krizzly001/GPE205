using UnityEngine;

public abstract class Shooter : MonoBehaviour //Parent
{
    //VARIABLES


    //BLUEPRINTS
    public abstract void Start();
    public abstract void Update();

    //FUNCTIONS
    //(object bullet, direction the bullet is going, amount of damage being done, bullets lifespan)
    public abstract void Shoot(GameObject shellPrefab, float fireForce, float damageDone, float lifeSpan);
}
