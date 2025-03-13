using UnityEngine;
using System.Collections.Generic;

public class PlayerController : Controller //Child
{
    // Variables

    public KeyCode moveFowardKey; //Input key choice
    public KeyCode moveBackwardKey; //Input Key choice
    public KeyCode rotateClockwiseKey; //Input Key choice
    public KeyCode rotateCounterClockwiseKey; //Input Key choice

    public KeyCode shootKey;//Input key choice



    //BLUEPRINTS
    public override void Start()
    {
        //Game Manager stuff

        if(GameManager.instance != null) //if game instance exist...
        {
            if(GameManager.instance.players != null)//and tracks player..
            {
                GameManager.instance.players.Add(this); //add into game manager list
            }
                
        }



        base.Start(); //Calls Parents start info
    }
    public override void Update()
    {
        //Checks for Key every moment
        ProcessInputs();
        base.Update(); //Calls Parents update info
    }


    //FUNCTIONS
    public override void ProcessInputs()
    {
        if (Input.GetKey(moveFowardKey))
        {
            pawnObject.MoveFoward(); //Calls TankPawn Functions
        }
        if (Input.GetKey(moveBackwardKey))
        {
            pawnObject.MoveBackward(); //Calls TankPawn Functions
        }
        if (Input.GetKey(rotateClockwiseKey))
        {
            pawnObject.RotateClockwise(); //Calls TankPawn Functions
        }
        if (Input.GetKey(rotateCounterClockwiseKey))
        {
            pawnObject.RotateCounterClockwise(); //Calls TankPawn Functions
        }
        if (Input.GetKeyDown(shootKey))//GetKeyDown: Can only be used on each press/ used onece not constant
        {
            pawnObject.Shoot();
        }
    }
}
