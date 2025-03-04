using UnityEngine;

public class AIController : Controller
{
    //VARIABLES

    public enum AIState{Guard, Chase, Flee};//Array of different type of states

    public AIState currentState; //Holds current state array name variable

    public GameObject target; //The AIBeing targets

    private float lastStateChangeTime; //When the state was applied

    public float targetDistance; //input

    public float hearingDistance;//input

    public float fieldOfView;//inout
    public int currentWaypoint = 0;


    //BLUEPRINTS
    
    public override void Start()
    {
        ChangeState(AIState.Guard); 
    }

    public override void Update()
    {
        ProcessInputs(); //updates my state everymoment its changed
        
    }

    //FUNCTIONS
    public override void ProcessInputs()
    {
        //if statements: if certain distance is near the AI itsll start that state
        switch (currentState)
        {
            case AIState.Guard:
            // Do work for Guard
                DoGuardState();
            // Chekc for transitions
                if (IsDistanceLessThan(target, targetDistance))
                {
                    if(CanSee(target))
                    {
                        ChangeState(AIState.Chase);
                    }
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

    public bool CanHear(GameObject target)
    {
        // Get the target's NoiseMaker
        NoiseMaker noiseMaker = target.GetComponent<NoiseMaker>();
        // If they don't have one, they can't make noise, so return false
        if (noiseMaker == null) 
        {
            return false;
        }
        // If they are making 0 noise, they also can't be heard
        if (noiseMaker.volumeDistance <= 0) 
        {
            return false;
        }
        // If they are making noise, add the volumeDistance in the noisemaker to the hearingDistance of this AI
        float totalDistance = noiseMaker.volumeDistance + hearingDistance;
        // If the distance between our pawn and target is closer than this...
        if (Vector3.Distance(pawn.transform.position, target.transform.position) <= totalDistance) 
        {
            // ... then we can hear the target
            return true;
        }
        else 
        {
            // Otherwise, we are too far away to hear them
            return false;
        }
    }

     public bool CanSee(GameObject target)
    {
        // Find the vector from the agent to the target
        Vector3 agentToTargetVector = target.transform.position - transform.position;
        // Find the angle between the direction our agent is facing (forward in local space) and the vector to the target.
        float angleToTarget = Vector3.Angle(agentToTargetVector, pawn.transform.forward);
        // if that angle is less than our field of view
        if (angleToTarget < fieldOfView) 
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    


   
}
