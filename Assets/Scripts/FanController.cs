using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FanBehaviour
{
    public class FanController : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            //Fan_ButtonController fbc = new Fan_ButtonController();
            //fbc.set = false;
            Fan_ButtonController.setFANONfalse();
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("FCFC");
        }
    }
}
