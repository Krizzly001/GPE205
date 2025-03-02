using UnityEngine;

public abstract class Mover : MonoBehaviour //Parent
{
   //BLUEPRINTS
    public abstract void Start();
    public abstract void Update();

    //FUNCTIONS
    public abstract void Move(Vector3 direction, float speed);
    public abstract void Rotate(float turnSpeed);
    
}
