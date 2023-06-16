using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace laptopController
{
    public class inletJudgeScript : MonoBehaviour
    {
        public bool isItOut = false;
        // Start is called before the first frame update
        MoveLaptopAnswerSheet las = new MoveLaptopAnswerSheet();
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float gx = gameObject.transform.position.x;
            float gy = gameObject.transform.position.y;
            float gz = gameObject.transform.position.z;
            float r = 0.2f;
            //3.051694 0.2107704 12.18626
            if (3.051694 - r <= gx && gx < +3.051694 + r &&
                 0.2107704 - r <= gy && gy <= 0.2107704 +r &&
                 12.18626 - r <= gz && gz <= 12.18626 + r)
            {
                //Debug.Log("in!!!!!");
                isItOut = false;
            }
            else
            {
                //Debug.Log(gx + " " + gy + " " + gz);
                //Debug.Log("out!!!");
                isItOut = true;
                laptopON_behaviour lTmp = new laptopON_behaviour();
                lTmp.turnOFFthat();
                las.setlaptopANStrue();
                gameObject.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}
