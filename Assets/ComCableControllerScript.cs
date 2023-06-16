using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace laptopController
{
    public class ComCableControllerScript : MonoBehaviour
    {
        //
        private LineRenderer lr;
        private Transform[] points;
        private void Awake(){
            lr=GetComponent<LineRenderer>();
        }
//

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            CableProceduralStatic tmp = gameObject.GetComponent<CableProceduralStatic>();
           // tmp.drawIt();
            Debug.Log("drawingIt!!");
        }
    }
}
