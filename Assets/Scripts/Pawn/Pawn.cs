//Parent Pawn: Used to create different pawn and desides how is behaves

using UnityEngine;
// Abstract: Child can Inherit
public abstract class Pawn : MonoBehaviour //Parent
{
    //VARIABLES

    // Public: Can be accessed to any other scripts doesnt have to be child
    public float moveSpeed; //Input
    public float turnSpeed;// Input


    public Mover storeMover; ///Access to my Mover Script, Parent and Child scripts
    public Shooter storeShooter;//Acess to my shooter Script

    //Assigning are function to are Shooter
    public GameObject shellPrefab; //the copys of my bullet
    public float fireForce;
    public float damageDone;
    public float shelllifespan;


    public float fireRate;


    


    //BLUEPRINTS
    public virtual void Start()
    {
        storeMover = GetComponent<Mover>(); //Connect Mover script to tank being moved
        storeShooter = GetComponent<Shooter>();
    }

    
    public virtual void Update()
    {
        
    }


    //FUNCTIONS: Abilities my tank has, which is moving
    public abstract void MoveFoward(); 
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();


    //my shooter
    public abstract void Shoot();

    public abstract void RotateTowards(Vector3 targetPosition);
    public abstract void RotateAway(Vector3 targetPosition);

}
