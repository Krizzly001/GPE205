using UnityEngine;

public class AIController : Controller
{
    //VARIABLES
    public enum AIState{Guard, Chase};
    public AIState currentState;


    //BLUEPRINTS
    
    public override void Start()
    {
        currentState = AIState.Guard;
    }

    public override void Update()
    {
        ProcessInputs();
        
    }

    //FUNCTIONS
    public override void ProcessInputs()
    {
        switch (currentState)
        {
            case AIState.Guard:
            // Do work for Guard
                DoGuardState();
            // Chekc for transitions
            break;

            case AIState.Chase:
            // Dow work for chase
                DoChaseState();
            //check for trasition
            break;
                
        }

    }

    public void DoGuardState()
    {
        //Do Nothing
    }
    public void DoChaseState()
    {
        //Do Chase
    }
}
