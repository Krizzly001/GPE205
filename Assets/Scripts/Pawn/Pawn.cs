using UnityEngine;
// Abstract: Allowed to have children/child can override
// Virtual: Child MIGHT override
public abstract class Pawn : MonoBehaviour //Parant
{
    //VARIABLES/INPUTS
    public float moveSpeed; // Speed of pawn/tank
    public float turnSpeed; // Turn Speed of pawn/tank

    public GameObject shellPrefab;
    public float fireForce;
    public float damageDone;
    public float shellLifespan;

    public float fireRate;

    public Mover mover; // public script(Mover) TankPawnsNewVariable

    //Access my shooter
    public Shooter shooter;

    
    //BLURPRINTS
    public virtual void Start()
    {
        mover = GetComponent<Mover>(); // Uses Mover component script       
        shooter = GetComponent<Shooter>();
    }
    public virtual void Update()
    {       
    }
    
    //FUNCTIONS

    // abilities are pawns can do
    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockwise();
    public abstract void RotateCounterClockwise();

    public abstract void Shoot();
}
