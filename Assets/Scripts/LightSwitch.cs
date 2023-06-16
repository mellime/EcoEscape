using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LightSwitch : MonoBehaviour
{
    public Light targetLight;
    private XRBaseInteractable interactable;
    private AudioSource audioSoure;

    void Start()
    {
        interactable = GetComponent<XRBaseInteractable>();
        interactable.onSelectEntered.AddListener(ToggleLight);

        audioSoure = GetComponent<AudioSource>();
    }

    void ToggleLight(XRBaseInteractor interactor)
    {
        targetLight.enabled = !targetLight.enabled;

        if (targetLight.enabled)
        {
            Debug.Log("������ �������ϴ�.");
        }
        else
        {
            Debug.Log("������ �������ϴ�.");
        }

        audioSoure.Play();
    }
}
