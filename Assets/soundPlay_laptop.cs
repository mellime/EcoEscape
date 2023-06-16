using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace laptopController
{
    public class soundPlay_laptop : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        protected internal void PlayIt()
        {
            AudioSource audiosource = gameObject.GetComponent<AudioSource>();
            audiosource.Play();
        }
    }
}