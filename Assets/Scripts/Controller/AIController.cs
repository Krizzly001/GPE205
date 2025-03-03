using UnityEngine;

public class AIController : Controller
{
    //VARIABLES
    public enum AIState{Guard, Chase, Flee};
    public AIState currentState;

    public GameObject target;

    private float lastStateChangeTime;

    public float targetDistance;


    //BLUEPRINTS
    
    public override void Start()
    {
        ChangeState(AIState.Guard);
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
                if (IsDistanceLessThan(target, targetDistance))
                {
                    ChangeState(AIState.Chase);
                }
            break;

            case AIState.Chase:
            // Dow work for chase
                DoChaseState();
            //check for trasition
                if (IsDistanceLessThan(target, targetDistance))
                {
                    ChangeState(AIState.Guard);
                }
            break;
            case AIState.Flee:
            // Dow work for chase
                DoFleeState();
            //check for trasition
                if (IsDistanceLessThan(target, targetDistance))
                {
                    ChangeState(AIState.Flee);
                }
            break;
                
        }

    }

    public void DoGuardState()
    {
        //Do Nothing
        Debug.Log("Doing Guard state");
    }
    public void DoChaseState()
    {
        //Do Chase
        Debug.Log("Doing Chase state");
        Seek(target);
    }
    public void DoSeekState()
    {
        // Seek our target
        Seek(target);
    }
    public void DoFleeState()
    {
        // Seek our target
        Flee(target);
    }



    public void Seek (GameObject target)
    {
        // RotateTowards the Funciton
        pawn.RotateTowards(target.transform.position);
        // Move Forward
        pawn.MoveForward();
    }
    public void Flee (GameObject target)
    {
        // RotateTowards the Funciton
        pawn.RotateAway(target.transform.position);
        // Move Forward
        pawn.MoveForward();
    }











    public bool IsDistanceLessThan(GameObject target, float distance)
    {
        if(Vector3.Distance (pawn.transform.position, target.transform.position) < distance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public virtual void ChangeState (AIState newState)
    {
        currentState = newState;
        lastStateChangeTime = Time.time;
    }

   
}
