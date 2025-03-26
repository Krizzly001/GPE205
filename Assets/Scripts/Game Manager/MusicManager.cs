using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager instance;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instance
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
