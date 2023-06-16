using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waterLoop : MonoBehaviour
{
    private bool isEffectPlaying = false;

    // �� ����Ʈ ã�� ����
    public ParticleSystem particleSystem;

    // �Ҹ�
    public AudioSource audioSource;

    //�ش� ������Ʈ ã��
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
        // ����Ʈ�� ���� ������ ����
        //var mainModule = particleSystem.main;
        //mainModule.loop = true;
        PlayEffect();

        //������Ʈ ã��
        topObject = GameObject.Find("bathroom");
        parentObject = topObject.transform.Find("hint_a");
        childObject = parentObject.transform.Find("eng_a");
        childObject_blur = parentObject.transform.Find("hint_blur");
    }

    private void Update()
    {
        if (isEffectPlaying == true)
        {
            //��ó��
            childObject_blur.gameObject.SetActive(true);
            childObject.gameObject.SetActive(false);
        }
        else
        {
            //��Ʈ���� (��x)
            childObject_blur.gameObject.SetActive(false);
            childObject.gameObject.SetActive(true);
        }
    }

    //�÷��� / ��ž �Լ�
    private void PlayEffect()
    {
        particleSystem.Play();
        isEffectPlaying = true;

        //�Ҹ�����
        audioSource.Play();
    }
    private void StopEffect()
    {
        particleSystem.Stop();
        isEffectPlaying = false;

        //�Ҹ� ����
        audioSource.Stop();
    }
}
