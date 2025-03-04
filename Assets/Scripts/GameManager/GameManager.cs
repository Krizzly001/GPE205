using UnityEngine;
using System.Collections.Generic; // Allows to use Lists<>

public class GameManager : MonoBehaviour
{
    //VARIABLES
    
    public static GameManager instance; //shared throughout the game

    //Stores player controllers from world, players are there name
    public List<PlayerController> players;


    //Input are object controller and tankpawn objects
    public GameObject playerControllerPrefab;
    public GameObject tankPawnPrefab;

    public Transform spawnPoint;

    //BLUEPRINTS

    //Behavior class: place before start() ALWAYS
    public void Awake()
    {
        players = new List<PlayerController>(); // Being added to the player controller list


        if(instance == null) //If my GameInstance does not exist
        {
            instance = this; // My instance will be (this gamemanager script)
            //Prevents my game object that has game manager attached being destroyed
            //when loading a new scene
            DontDestroyOnLoad(gameObject); 
        }
        else //Prevents making duplicate game managers
        {
            Destroy(gameObject);
        }

    }
    

    void Start()
    {
        SpawnPlayer();
        
    }
    void Update()
    {
        
    }




    //FUNCTIONS

    public void SpawnPlayer()
    {
        //Player Controller
        // NewPlayerObj = BeSpawned(TypeOfObjBeingSpawned, Location(0,0,0), No Rotation)
        GameObject newPlayerObj = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity);

        //Pawn/Tank
        // NewPawnObj = BeSpawned(TypeOfObjBeingSpawned, at spawnpointsPosition, spawnPointsRotation)
        GameObject newPawnObj = Instantiate(tankPawnPrefab, spawnPoint.position, spawnPoint.rotation);

        Controller newController = newPlayerObj.GetComponent<Controller>();
        Pawn newPawn = newPawnObj.GetComponent<Pawn>();

        newPawnObj.AddComponent<NoiseMaker>();
        newPawn.noiseMaker = newPawnObj.GetComponent<NoiseMaker>();
        newPawn.noiseMakerVolume = 3;

        newController.pawn = newPawn;
    }
}
