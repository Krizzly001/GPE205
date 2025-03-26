using UnityEngine;

public class SFX : MonoBehaviour
{
    public GameObject ShooterSFX;
    public GameObject MovingSFX;
    public GameObject ClickSFX;

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShooterSFX.SetActive(false);
            ShooterSFX.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
           MovingSFX.SetActive(true);

        }
        else if(Input.GetKeyUp(KeyCode.W))
        {
            MovingSFX.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ClickSFX.SetActive(false);
            
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            ClickSFX.SetActive(true);
        }

        
    }
}
