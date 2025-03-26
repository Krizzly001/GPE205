using UnityEngine;

public class SFX : MonoBehaviour
{
    public GameObject ShooterSFX;

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShooterSFX.SetActive(false);
            ShooterSFX.SetActive(true);
        }
        
    }
}
