using UnityEngine;

public class AIController : Controller
{
    //VARIABLES
    //Different "personalities" are AI can inherit/have
    public enum AIState {Guard, Chase, Flee}; //enum == array

    //Automatic state are AI will have
    public AIState currentState;

    //Target I am Chasing... which is target
    public GameObject target; // The tank  the user controls

    //Save the last state we were in
    private float lastStateChangeTime;

    public float targetDistance;
    public float targetDistanceFlee;



    //BLUEPRINTS
    public override void Start()
    {
        
        
    }

    
    public override void Update()
    {
        ProcessInputs();
    }

    //FUNCTIONS
    public override void ProcessInputs()//"listens for keys.
    {
        switch(currentState)//if current state is... 
        {
            case AIState.Guard://to Guard

                //FOR FLEE    
                DoGuardState();
                if(targetDistance == 0)//Its for Flee
                {
                    if(IsDistanceLessThan(target, targetDistanceFlee))//(user tank, distance limit)
                    {
                        //if user tank too close(under 10) AI will chase
                        ChangeState(AIState.Flee);
                    }
                }
                
                //FOR CHASE
                if(IsDistanceLessThan(target, targetDistance))//(user tank, distance limit)
                {
                    //if user tank too close(under 10) AI will chase
                    ChangeState(AIState.Chase);
                }
                
                break;

            case AIState.Chase://to chase
                //Does chase stuff...
                DoChaseState();

                if(!IsDistanceLessThan(target, targetDistance))//(user tank, distance limit)
                {
                    //if user tank too close(under 10) AI will guard and not chase
                    ChangeState(AIState.Guard);
                }
                
                break;

            case AIState.Flee://to flee
        
                if(IsDistanceLessThan(target, targetDistanceFlee))//(user tank, distance limit)
                {
                    //if user tank too close(under 10) AI will guard and not chase
                    DoFleeState();
                    if(IsDistanceLessThan(target, targetDistanceFlee))
                    {
                        ChangeState(AIState.Guard);
                    }
                    
                }
                
            break;


        }

    }

    //STATE CALCULATIONS


    //Guard stuff calculations
    public void DoGuardState()
    {
        //Do Nothing
        Debug.Log("Guardinggg");
    }

    //Chase stuff calculations
    public void DoChaseState()
    {
        ChaseTarget(target);
        //Seek for target
        Debug.Log("Chasinggg");
    }
    public void DoFleeState()
    {
        FleeTarget(target);
        //Seek for target
        Debug.Log("Fleeing");
    }

    public bool IsDistanceLessThan(GameObject target, float distance)
    {
        // if my AItank's position/transform and users tank position/trandform is less then the dthe distance I want the to be...
        if(Vector3.Distance (pawnObject.transform.position, target.transform.position) < distance)
        {
            return true;// if they are less then the distance I want them to be, "chase user tank"
        }
        else
        {
            return false;// if bigger do nothing.
        }
    }


    public virtual void ChangeState(AIState nextState) //Are default would be Guard tho.
    {
        //ex. if currentState is Guard save for when I finish chasing
        // saves into newState
        currentState = nextState;

        //Save current time when state is changed 
        lastStateChangeTime = Time.time; 
    }

    //Seek for users tank
    public void ChaseTarget (GameObject target)
    {
        // RotateTowards the Funciton
        pawnObject.RotateTowards(target.transform.position);
        // Move Forward
        pawnObject.MoveFoward();
    }
    public void FleeTarget (GameObject target)
    {
        // RotateTowards the Funciton
        pawnObject.RotateAway(target.transform.position);
        // Move Forward
        pawnObject.MoveFoward();
    }
   


}

