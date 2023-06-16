using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace laptopController
{

    public class laptopON_behaviour : MonoBehaviour
    {
        private AudioSource theAudio; //음원재생기
        [SerializeField] private AudioClip clip; //음원

        static bool tot_bool = false;
        bool isEventfirst = true;
        static void set_tBooltrue()
        {
            tot_bool = true;
        }
        // Start is called before the first frame update
        void Start()
        {
            //gameObject.transform.Translate(1.0f, 0, 0);
            //gameObject.transform.Translate(0, 0, 10.0f);
            theAudio = GetComponent<AudioSource>();
        }
        public void Play()
        {

            theAudio.clip = clip; //clip의 0번째 배열을 꺼내옴
            theAudio.Play(); //재생. 
        }
        // Update is called once per frame
        void Update()
        {
            //inletJudgeScript jTmp = new inletJudgeScript();
            //if (jTmp.isItOut == true)
            //{
            //    Debug.Log();
            //    gameObject.transform.Translate(1.0f, 0, 0);
            //}
            if (tot_bool == true)
            {
                //Debug.Log("herIaMMM!!");
                //gameObject.transform.Translate(1.0f, 0, 0);
                if (isEventfirst == true)
                {
                    gameObject.GetComponent<Renderer>().enabled = !gameObject.GetComponent<Renderer>().enabled;
                    isEventfirst = false;

                    Play();
                }
                tot_bool = false;
            }

        }
        public void turnOFFthat()
        {
            //Debug.Log("tot on");
            set_tBooltrue();//tot_bool = true;
            //gameObject.transform.Translate(0, 0, 10.0f);
        }
    }
}
