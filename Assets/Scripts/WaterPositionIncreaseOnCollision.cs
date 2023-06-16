using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPositionIncreaseOnCollision : MonoBehaviour
{
    private bool collided = false;
    private float initialY;
    private float yOffset = 0.15f;
    private Collider objectCollider;
    public GameObject targetObject;

    private void Start()
    {
        objectCollider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collided && collision.gameObject == targetObject)
        {
            collided = true;
            initialY = transform.position.y;
            IncreaseYPosition();
            DisableCollider();
        }
    }

    private void IncreaseYPosition()
    {
        Vector3 newPosition = transform.position + new Vector3(0f, yOffset, 0f);
        transform.position = newPosition;
    }

    private void DisableCollider()
    {
        objectCollider.enabled = false;
    }
}
