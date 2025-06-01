using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Email : MonoBehaviour

{
    [SerializeField] private Button emailNotif;
    [SerializeField] private Animator emailNotifAnim;
    [SerializeField] private Animator emailTabAnim;

    [SerializeField] private TMP_Text receiverField;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        receiverField.text = $"{playerName}";

        Button btn = emailNotif.GetComponent<Button>();
        btn.onClick.AddListener(emailRecieved);
    }

    public void emailRecieved()
    {
        Debug.Log("Email Recieved");
        emailNotifAnim.SetBool("IsOpen", false);
        emailTabAnim.SetBool("IsOpen", true);

    }
    public void UpdateReceiverName(string newName)
    {
        receiverField.text = newName;
    }


}