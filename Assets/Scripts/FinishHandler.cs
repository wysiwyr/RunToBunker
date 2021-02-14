using UnityEngine;

public class FinishHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas gameClearCanvas;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.enabled = false;
        gameClearCanvas.enabled = false;
    }

    public void HandleFinish(bool success)
    {
        if (success)
        {
            gameClearCanvas.enabled = true;
        }
        else
        {
            gameOverCanvas.enabled = true;
        }
        
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
