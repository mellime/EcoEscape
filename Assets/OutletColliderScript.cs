using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutletColliderScript : MonoBehaviour
{
    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("enter");
    }
    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("stay");
    }
    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("exit");
    }


   
}
