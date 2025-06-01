using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    [SerializeField] Animator phone;  
    private bool isOpen = false;     

    public void TogglePhone()
    {
        isOpen = !isOpen;           
        phone.SetBool("IsOpen", isOpen); 
    }
}
