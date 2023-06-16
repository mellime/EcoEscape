using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterLoop : MonoBehaviour
{
    private bool isEffectPlaying = false;

    // 물 이펙트 찾기 위함
    public ParticleSystem particleSystem;

    // 소리
    public AudioSource audioSource;

    //해당 오브젝트 찾기
    public GameObject topObject;
    public Transform parentObject;
    public Transform childObject;
    public Transform childObject_blur;

    public void OnMouseDown()
    {
        if (isEffectPlaying)
            StopEffect();
        else
            PlayEffect();
    }

    private void Start()
    {
        // 이펙트를 무한 루프로 설정
        //var mainModule = particleSystem.main;
        //mainModule.loop = true;
        PlayEffect();

        //오브젝트 찾기
        topObject = GameObject.Find("bathroom");
        parentObject = topObject.transform.Find("hint_a");
        childObject = parentObject.transform.Find("eng_a");
        childObject_blur = parentObject.transform.Find("hint_blur");
    }

    private void Update()
    {
        if (isEffectPlaying == true)
        {
            //블러처리
            childObject_blur.gameObject.SetActive(true);
            childObject.gameObject.SetActive(false);
        }
        else
        {
            //힌트쪽지 (블러x)
            childObject_blur.gameObject.SetActive(false);
            childObject.gameObject.SetActive(true);
        }
    }

    //플레이 / 스탑 함수
    private void PlayEffect()
    {
        particleSystem.Play();
        isEffectPlaying = true;

        //소리사운드
        audioSource.Play();
    }
    private void StopEffect()
    {
        particleSystem.Stop();
        isEffectPlaying = false;

        //소리 사운드
        audioSource.Stop();
    }
}
