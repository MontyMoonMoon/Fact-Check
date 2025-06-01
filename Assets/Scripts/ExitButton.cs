using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public GameObject targetToClose;

    [SerializeField] public Animator panelAnim;

    public bool hidePanel = false;
    public bool resetAnim = false;
    public bool destroyOnExit = false;

    public void Exit()
    {
        if (targetToClose == null)
        {
            Debug.LogWarning("No targetToClose assigned on " + gameObject.name);
            return;
        }

        if (resetAnim)
        {
            panelAnim.SetBool("IsOpen", false);
        }

        if (destroyOnExit)
        {
            Destroy(targetToClose);

        }
        
        if (hidePanel)
        {
            targetToClose.SetActive(false);
        }
    }
}
