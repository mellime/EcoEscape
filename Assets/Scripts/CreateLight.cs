using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLight : MonoBehaviour
{
    public bool collided = false;
    public Collider objectCollider;
    public GameObject targetObject;
    public GameObject oldLightObject;
    public static bool oldLightOn = false;

    void Start()
    {
        oldLightObject.gameObject.SetActive(false);
        objectCollider = GetComponent<Collider>();
    }

    void Update()
    {
        if (oldLightOn == true)
        {
            oldLightObject.gameObject.SetActive(true);
        }
    }

    public static void setLightTrue()
    {
        oldLightOn = true;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (!collided && collision.gameObject == targetObject)
        {
            collided = true;
            setLightTrue();
        }
    }
}
