using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    
    public void StartScene()
    {

        
        SceneManager.LoadScene("TankGame");
        UnityEngine.SceneManagement.SceneManager.LoadScene("TankGame");
    }
}
