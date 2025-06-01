using UnityEngine;
using TMPro;

public class ErrorMessagePanel : MonoBehaviour
{
    [SerializeField] private TMP_Text messageText;

    // Uses a string from a different script when called
    public void SetMessage(string message)
    {
        if (messageText != null)
            messageText.text = message;
    }

    // Deletes the prefab from the scene
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
