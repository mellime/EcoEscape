using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace FanBehaviour
{
 
    public class Fan_ButtonController : MonoBehaviour
    {
        public Light targetLight;
        private XRBaseInteractable interactable;
        public static bool fan_ON = true;
        // Start is called before the first frame update
        //public bool isfanon()
        //{
        //    return fan_ON;
        //}
        public static bool setFANONtrue()
        {
            fan_ON = true;
            return fan_ON;
        }
        public static bool setFANONfalse()
        {
            fan_ON = false;
            return fan_ON;
        }
        public static bool setFANONswitch()
        {
            fan_ON = !fan_ON;
            return fan_ON;
        }
        public bool isfanon()
        {
            return fan_ON;
        }
        void Start()
        {
            interactable = GetComponent<XRBaseInteractable>();
            targetLight.enabled = !targetLight.enabled;
            interactable.onSelectEntered.AddListener(turnFan);
            //fan_ON = false;
        }
        void Update()
        {
            
           

        }
        void turnFan(XRBaseInteractor interactor)
        {
            targetLight.enabled = !targetLight.enabled;
            setFANONswitch();
            //Debug.Log("turnFan : " + fan_ON);
            //if (targetLight.enabled)
            //{
            //    fan_ON = true;
            //    Debug.Log(fan_ON);
            //}
            //else
            //{
            //    fan_ON = false;
            //    Debug.Log(fan_ON);
            //}
        }
      
        
    
    }
}
