using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsScript : MonoBehaviour
{
    public void OptionsScene()
    {

        
        SceneManager.LoadScene("Options");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Options");
    }
}
