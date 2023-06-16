using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Milk : TrashObject
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Trashbin"))
        {
            if (other.name == "living_room_Trashbin_Paper")
            {
                Trashbin trashbin = other.GetComponent<Trashbin>();
                trashbin.itemCount++;
            }
            gameObject.SetActive(false);
        }
    }
}

