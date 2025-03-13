//The tank that can get pickups/powerups

using UnityEngine;
using System.Collections.Generic;

public class PowerupManager : MonoBehaviour
{
    //VARIABLES
    //List of power ups
    public List<Powerup> powerups;

    private List<Powerup> removePowerupQueue;

    //BLUEPRINTS
   
    void Start()
    {
        //Create a new list names powerups
        powerups = new List<Powerup>();
        removePowerupQueue = new List<Powerup>();
        
    }
    void Update()
    {
        //Checks if the timer is done every moment.
        DecrementPowerupTimers();
        
    }

    public void LateUpdate()
    {
        //Removes from temp queue
        ApplyRemovePowerupQueue();

    }


    //BLUEPRINTS

    //Adds my powerup
    public void Add(Powerup powerupToAdd)
    {
        //Permits me to use this powerup pretty much/permission to heal
        powerupToAdd.Apply(this);

        //Add to are powerups list
        powerups.Add(powerupToAdd);

    }

    //Removes my powerup
    public void Remove(Powerup powerupToRemove)
    {
        //remove the powerup in DecrementPowerupTimers(); on Remove(powerups), connected
        powerupToRemove.Remove(this);

        //Adds into queue
        removePowerupQueue.Add(powerupToRemove);




    }
    //FUNCTIONS



    //Decides how long a powerup can last
    public void DecrementPowerupTimers()
    {
        //For each powerup in the powerups List
        foreach(Powerup powerup in powerups)
        {
            if(!powerup.isPermanent)//if pwerup is not(fasle) permanent
            {
                //Subtract the time it takes to make a frame
                powerup.duration -= Time.deltaTime;
                //Remove once the timers up...
                if(powerup.duration <= 0)
                {
                    Remove(powerup);//Removes it
                }
            }
        }
    }

    private void ApplyRemovePowerupQueue()
    {
        //For each powerup in the removePowerupQueue List
        foreach(Powerup powerup in removePowerupQueue)
        {
            //Removes the powerups from the powerups list
            powerups.Remove(powerup); 
        }
        //and resets our temp list
        removePowerupQueue.Clear();

    }





}
