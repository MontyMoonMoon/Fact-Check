using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopApp : MonoBehaviour
{
  [SerializeField] GameObject LaptopApp1;
  [SerializeField] GameObject LaptopApp2;

  public void OpenApp1()
  {
    LaptopApp1.SetActive(true);
    LaptopApp2.SetActive(false);
  }

  public void OpenApp2()
  {
        LaptopApp1.SetActive(false);
        LaptopApp2.SetActive(true);
    }
  public void CloseAppDelayed()
    {
        StartCoroutine(CloseAfterFrame());
    }

    IEnumerator CloseAfterFrame()
    {
        // Wait until the end of frame to ensure OnClick finishes
        yield return null;
        LaptopApp1.SetActive(false);
        LaptopApp2.SetActive(false);
    }
}
