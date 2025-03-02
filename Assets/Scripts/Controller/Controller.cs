using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    //VARIABLES: My Dev inputs
    public Pawn pawn; // Grabs the pawn being controlled/ dev inputs

    //BLUEPRINTS
    public virtual void Start()
    {      
    }
    public virtual void Update()
    {
    }

    //FUNCTION
    public abstract void ProcessInputs();
}
