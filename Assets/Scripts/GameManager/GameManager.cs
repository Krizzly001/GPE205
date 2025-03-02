using UnityEngine;
using System.Collections.Generic; // Allows to use Lists<>

public class GameManager : MonoBehaviour
{
    //VARIABLES
    
    public static GameManager instance; //shared throughout the game

    //Stores player controllers from world, players are there name
    public List<PlayerController> players;

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
        
    }
    void Update()
    {
        
    }
}
