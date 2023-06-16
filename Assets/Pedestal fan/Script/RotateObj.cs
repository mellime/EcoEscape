using UnityEngine;
using System.Collections;
namespace FanBehaviour
{
	public class RotateObj : MonoBehaviour
	{
		public bool FanRunning = false;
		public float degreePerSecond = 5;
		public int x;
		public int y;
		public int z;
		public bool soundOn = false;//sound is playing now?
        // Use this for initialization

        private AudioSource theAudio; //음원재생기
        [SerializeField] private AudioClip clip; //음원

        void Start()
		{
            theAudio = GetComponent<AudioSource>();
        }
        public void PlayAudio()
        {
			Debug.Log("playaudioon");
            theAudio.clip = clip; //clip의 0번째 배열을 꺼내옴
            theAudio.mute = false;
            theAudio.Play(); //재생. 
        }
		public void MuteAudio()
		{
			theAudio.clip = clip;
			theAudio.mute=true;
		}
        // Update is called once per frame
        void Update()
		{ 
			// Debug.Log(gameObject.GetComponent<Fan_ButtonController>().fan_ON);
			//Fan_ButtonController bTmp = gameObject.GetComponent<Fan_ButtonController>();
			Fan_ButtonController bTmp = new Fan_ButtonController();
			moveFanAnswer mfaV = new moveFanAnswer();
			
            Debug.Log("turn ... on rotateObj.cs "+bTmp.isfanon());
            //gameObject.transform.Rotate(Vector3.right * Time.deltaTime * (degreePerSecond));
            AudioSource audioSource = gameObject.AddComponent<AudioSource>();
            if (bTmp.isfanon() == true)
			{
				mfaV.setfanANStrue();
				Debug.Log("111 fanon->false in rotateUPDATE");
				gameObject.transform.Rotate(Vector3.right * Time.deltaTime * (degreePerSecond));
				//audioSource.Play();
				
				Debug.Log("111 afterROtate");
				if (soundOn == false)
				{
					Debug.Log("111 in IFState"+soundOn);
                    PlayAudio();
                    soundOn = true;
				}
				
			}
			else
			{
                Debug.Log("Excepted1");
                MuteAudio();
				soundOn = false;
				Debug.Log("Excepted");
			}
		}
	}
}
