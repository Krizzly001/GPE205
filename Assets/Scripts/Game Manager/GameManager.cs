using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    //VARIABLES
    //Make is work as a singleton
    public static GameManager instance;

    //List name: players
    //Type: PlayerController
    // List data stucture: Used to store same type of objects
    public List<PlayerController> players;



    //SPAWNING
    public GameObject playerControllerPrefab;
    public GameObject tankPawnPrefab;

    //AI spawning   
    public GameObject aiControllerPrefab;

    //Pickup spawning
    public GameObject healthPickupPrefab;
    

    
    //temp variable--
   


    //Store a refence to our MapGenerator
    public MapGenerator mapGenerator;
    //array of spawn points
    private PawnSpawnPoint[] pawn_SpawnPoints;
    private AIPawnSpawnPoint[] aIPawnSpawnPoints;
    private HealthPickupSpawnPoint[] healthPickupPoints;


    public int mapSeed;

    
    









    //FUNC.: mono behavior class runs before staart
    public void Awake()
    {
        Random.InitState(mapSeed);
        

        //If there is no game instance..
        if(instance == null)
        {
            instance = this; //intance is this...

            //Prevent the empty game object in the world that holds
            //the game instance from being destroyed once it runs
            //if already placed
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);


        }
        //Adds new players into the players list
        players = new List<PlayerController>();

    }
    




    //BLUEPRINTS
    void Start()
    {
        //Check if mapGenerator already exist in are world..Generatemap
        if(mapGenerator != null)
        {
            mapGenerator.GenerateMap();
        }
        SpawnPlayer();

        SpawnAIs();
        SpawnAIs();
        SpawnAIs();
        SpawnAIs();

        SpawnHealthPickup();
        SpawnHealthPickup();
        SpawnHealthPickup();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //FUNCTIONS

    public void SpawnPlayer()
    {
        //Finding multiple spawn points in map
        pawn_SpawnPoints = FindObjectsByType<PawnSpawnPoint>(FindObjectsSortMode.None);
        if (pawn_SpawnPoints != null)
        {
            if(pawn_SpawnPoints.Length > 0)
            {
                GameObject spawnPoint = pawn_SpawnPoints[Random.Range(0, pawn_SpawnPoints.Length)].gameObject;



                //Spawn(PlayerControllerPrefab, at vector(0,0,0), with zero rotation),
                //place it in newPlayerObj
                GameObject newPlayerObj = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity);

                //Spawn(tankpawnprefab, at spawnpoint object, and spawnpoint object rotation)
                //place it in newPawnObj
                GameObject newPawnObj = Instantiate(tankPawnPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);

                //Retrieve player controller from our new player object
                Controller newController = newPlayerObj.GetComponent<Controller>();
                Pawn newPawn = newPawnObj.GetComponent<Pawn>();

                //Hook it up
                newController.pawnObject = newPawn;


            }
        }

    }

    public void SpawnAIs()
    {
        aIPawnSpawnPoints = FindObjectsByType<AIPawnSpawnPoint>(FindObjectsSortMode.None);
        if (aIPawnSpawnPoints != null)
        {
            if(aIPawnSpawnPoints.Length > 0)
            {
                GameObject spawnPoint = aIPawnSpawnPoints[Random.Range(0, aIPawnSpawnPoints.Length)].gameObject;



                //Spawn(PlayerControllerPrefab, at vector(0,0,0), with zero rotation),
                //place it in newPlayerObj
                GameObject newPlayerObj = Instantiate(aiControllerPrefab, Vector3.zero, Quaternion.identity);

                //Spawn(tankpawnprefab, at spawnpoint object, and spawnpoint object rotation)
                //place it in newPawnObj
                GameObject newPawnObj = Instantiate(tankPawnPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);

                //Retrieve player controller from our new player object
                Controller newController = newPlayerObj.GetComponent<Controller>();
                Pawn newPawn = newPawnObj.GetComponent<Pawn>();

                //Hook it up
                newController.pawnObject = newPawn;


            }
        }


    }

    public void SpawnHealthPickup()
    {
        healthPickupPoints = FindObjectsByType<HealthPickupSpawnPoint>(FindObjectsSortMode.None);
        if (healthPickupPoints != null)
        {
            if(healthPickupPoints.Length > 0)
            {
                GameObject spawnPoint = healthPickupPoints[Random.Range(0, healthPickupPoints.Length)].gameObject;

                GameObject healthObj = Instantiate(healthPickupPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);


            }

        }
    }
}
