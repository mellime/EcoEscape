using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ResetBtn : MonoBehaviour
{
    public TextMesh hint;
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        hint = GetComponentInChildren<TextMesh>();
    }


    // Update is called once per frame
    void Update()
    {
        Trashbin can = GameObject.Find("living_room_Trashbin_Can").GetComponent<Trashbin>();
        Trashbin plastic = GameObject.Find("living_room_Trashbin_Plastic").GetComponent<Trashbin>();
        Trashbin paper = GameObject.Find("living_room_Trashbin_Paper").GetComponent<Trashbin>();

        if(can.itemCount == 1 && plastic.itemCount == 1 && paper.itemCount == 1)
        {
            hint.text = "E";
        }
    }

    private void OnActivate(XRBaseInteractor interactor)
    {
        ResetTrashObjects();
    }

    private void ResetTrashObjects()
    {
        TrashObject[] trashObjects = FindObjectsOfType<TrashObject>();
        foreach (TrashObject trashObject in trashObjects)
        {
            trashObject.ResetPosition();
        }
    }
}