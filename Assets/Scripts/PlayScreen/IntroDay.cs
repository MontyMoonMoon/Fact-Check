using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroDay : MonoBehaviour
{
    [SerializeField] public GameObject PanelActive;
    [SerializeField] public Animator dayAndNewspaper;
    void Start()
    {
        PanelActive.SetActive(true);
        dayAndNewspaper.SetBool("isUp", true);
    }

    public void OnStartButton()
    {
        PanelActive.SetActive(false);
        dayAndNewspaper.SetBool("isUp", false);
    }
}
