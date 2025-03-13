//My healthy object in world
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    //VARIABLES

    public HealthPowerup powerup;

    //BLUEPRINTS
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    //FUNCTIONS

    public void OnTriggerEnter(Collider other) //other = users tank
    {
        //Store my tanks PowerupManager into powerupManager

        PowerupManager powerupManager = other.GetComponent<PowerupManager>();
        if(powerupManager != null)//if my powerManager does exist in the users tank or has a PowerManager...
        {
            //Add the powerup...
            powerupManager.Add(powerup);

            //Then destroy this pickup object
            Destroy(gameObject);
        }
    }
}
