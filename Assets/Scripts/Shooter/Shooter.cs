using UnityEngine;

public abstract class Shooter : MonoBehaviour
{
   //VARIABLES

   //BLUEPRINTS
   public abstract void Start();
   public abstract void Update();

   //FUNCTIONS
   //(BulletPrefab object file, speed of bullet, damage it can take to others, lifespan of bullet)
   public abstract void Shoot(GameObject shellPrefab, float fireForce, float damageDone, float lifespan);
}
