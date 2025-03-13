using UnityEngine;

public abstract class Mover : MonoBehaviour //Parent
{
    //VARIABLES



    //BLUPRINTS
    //Wont really need them
    public abstract void Start();
    public abstract void Update();

    //FUNCTIONS
    //(Directiong we are moving to, how fast we ae moving )
    public abstract void Move(Vector3 direction, float speed);
    public abstract void Rotate(float turnSpeed);
}
