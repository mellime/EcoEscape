using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FanBehaviour
{
    public class moveFanAnswer : MonoBehaviour
    {
        
        static bool isFanSolved = false;
        static bool eventIsInitial = true;
        static bool set_fBooltrue()
        {
            isFanSolved = true;
            return isFanSolved;
        }
        public bool isFanAnsSolved_M()
        {
            return isFanSolved;
        }
        // Start is called before the first frame update
        void Start()
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        // Update is called once per frame
        void Update()
        {
            Rigidbody rig = gameObject.GetComponent<Rigidbody>();
            if (isFanSolved == true && eventIsInitial==true)
            {
                //Debug.Log("fan solve true!");
                //gameObject.transform.Translate(1.0f, 0, 0);
                //Debug.Log("101 sheet :" + gameObject.transform.position);
                // gameObject.transform.Translate(-52.0f,0,0);
                //Debug.Log("101 sheet :" + gameObject.transform.position);
                gameObject.GetComponent<Renderer>().enabled = !gameObject.GetComponent<Renderer>().enabled;
                rig.useGravity = !rig.useGravity;
                isFanSolved = false;
                eventIsInitial = false;
            }
            //Debug.Log("101 00 sheet :" + gameObject.transform.position);
        }
        public void setfanANStrue()
        {
            ///aaa;
            //Debug.Log("tot on");
            set_fBooltrue();//
        }
    }
}
