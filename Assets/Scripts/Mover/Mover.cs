using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public abstract void Start();

    // Update is called once per frame
    public abstract void Update();

    public abstract void Move(Vector3 direction, float speed);
    public abstract void Rotate(float turnSpeed);
    
}
