using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    
    public void MenuScene()
    {

        
        SceneManager.LoadScene("TestMenu");
        UnityEngine.SceneManagement.SceneManager.LoadScene("TestMenu");
    }
}