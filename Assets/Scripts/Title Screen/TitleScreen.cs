using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    [SerializeField] private NewGameTS newGameHandler;
    [SerializeField] private GameObject settingsPrefab;

    public void OnPlayButton()
    {
        // if a save file exists this script will load that 
        if (PlayerPrefs.HasKey("SaveFile"))
        {
            SceneManager.LoadScene("Game Scene");
            Debug.Log("Loading Game Scene...");
        }
        else
        {
            // sript that handles first time players
            newGameHandler.HandleNewPlayer();
        }
    }

    public void OnSettingsButton()
    {
        Debug.Log("Settings Tab is open.");

        if (settingsPrefab != null)
        {
            GameObject canvas = GameObject.Find("Canvas");
            Instantiate(settingsPrefab, canvas.transform); // or transform if you want it inside the current canvas hierarchy
        }
        else
        {
            Debug.LogWarning("Settings prefab not assigned in the inspector.");
        }
    }

    public void OnCreditsButton()
    {
        Debug.Log("Rolling credits.");
    }

    public void OnExitButton()
    {
        Debug.Log("Exit button clicked. Exiting game...");
        Application.Quit();
    }
}
