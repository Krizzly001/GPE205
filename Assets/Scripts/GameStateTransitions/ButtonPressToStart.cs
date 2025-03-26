using UnityEngine;

public class ButtonPressToStart : MonoBehaviour
{

    public void ChangeToMainMenu ()
    {
        if (GameManager.instance != null) {
            GameManager.instance.ActivateMainMenu();
        }
    }
}
