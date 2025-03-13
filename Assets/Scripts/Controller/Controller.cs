using UnityEngine;
// Abstract: Child can Inherit
public abstract class Controller : MonoBehaviour //Parent
{
    //VARIABLES
    public Pawn pawnObject; //Access to my Pawn Script, Parent and Child scripts



    //BLUEPRINTS
    //Virtual: Might be used
    public virtual void Start()
    {
        
    }
    public virtual  void Update()
    {
        
    }


    //FUNCTIONS
    public abstract void ProcessInputs();
}
