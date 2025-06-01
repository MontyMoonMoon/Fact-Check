using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laptop : MonoBehaviour
{
  [SerializeField] GameObject laptopScreen;

    public void FullScreen()
    {
        laptopScreen.SetActive(true);
     }

    public void OnExit()
    {
        laptopScreen.SetActive(false);
    }
}
