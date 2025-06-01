using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class NewGameTS : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerNameInput;
    [SerializeField] private GameObject errorMessagePrefab;
    [SerializeField] private Transform errorContainer;
    [SerializeField] private Animator emailNotifAnim;

    [SerializeField] private GameObject acceptButton;

    public void HandleNewPlayer()
    {
        string playerName = playerNameInput.text.Trim();

        if (string.IsNullOrWhiteSpace(playerName))
        {
            ShowError("Name field is empty!");
            return;
        }

        if (playerName.Length < 3 || playerName.Length > 12)
        {
            ShowError("Must use 3–12 characters!");
            return;
        }

        Debug.Log("Player name: " + playerName);
        PlayerPrefs.SetString("PlayerName", playerName);

        // Update the Email receiver field manually
        Email emailScript = FindObjectOfType<Email>();
        if (emailScript != null)
        {
            emailScript.UpdateReceiverName(playerName);
        }

        StartCoroutine(TriggerEmailNotification());
    }

    // Adds delay to the email notif 
    private IEnumerator TriggerEmailNotification()
    {
        yield return new WaitForSeconds(1f);
        emailNotifAnim.SetBool("IsOpen", true);
    }

    // Instantiates the error prefab to spawn
    private void ShowError(string message)
    {
        GameObject errorGO = Instantiate(errorMessagePrefab, errorContainer);
        ErrorMessagePanel panel = errorGO.GetComponent<ErrorMessagePanel>();

        if (panel != null)
        {
            panel.SetMessage(message);
        }

        // Clears the input
        playerNameInput.text = string.Empty;
        playerNameInput.ActivateInputField();
    }
    
    // Loads Act 1 of the game
    public void OnAccept()
    {
        SceneManager.LoadScene("Game Scene");
        Debug.Log("Loading Game Scene...");
    }

}
