using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundPlay_fan : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.Play();
    }
}
