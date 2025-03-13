using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    //VARIABLES
    public GameObject pickupPrefab; //MyHealth_pickup prefab/the health object

    public float spawnDelay; //Time for it to spawn object again

    private float newSpawnTime; //Next time it can sapwn again


    private GameObject spawnedPickup;//The Prefab that was already spawne in


    //BLUEPRINTS
    void Start()
    {
        newSpawnTime = Time.time + newSpawnTime; //Deside the future time itll spawn
    }
    void Update()
    {
        if(spawnedPickup == null)//if the prefab is not in the world..
        {
            //Spawn a prefab
            // If it is time to spawn a pickupPrefab
            if(Time.time > newSpawnTime)//if the time is bigger then the time is can spawn again...
            {
                //Spawn the pickupPrefab at the location it was in no rotation
                spawnedPickup = Instantiate(pickupPrefab, transform.position, Quaternion.identity);
                newSpawnTime = Time.time + spawnDelay; //"Resets" when it can spawn again

            }
        }
        else //if there is a prefab in the world
        {
            //Keep updating the spawn time
            newSpawnTime = Time.time + spawnDelay; //"Resets" when it can spawn again


        }
        
        
        
    }

    //FUNCTIONS
}
