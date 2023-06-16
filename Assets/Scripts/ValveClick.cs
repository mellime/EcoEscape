using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ValveClick : MonoBehaviour
{
    private XRBaseInteractable interactable;
    public static bool valve_on = false;
    public GameObject paperObject;

    public static bool setValveOnTrue()
    {
        valve_on = true;
        return valve_on;
    }

    void Start()
    {
        paperObject.gameObject.SetActive(false);
        interactable = GetComponent<XRBaseInteractable>();
        interactable.onSelectEntered.AddListener(clickValve);
    }

    void Update()
    {
        if (valve_on == true)
        {
            paperObject.gameObject.SetActive(true);
        }
    }

    void clickValve(XRBaseInteractor interactor)
    {
        setValveOnTrue();
    }
}
