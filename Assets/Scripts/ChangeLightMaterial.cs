using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightMaterial : MonoBehaviour
{
    public Material onMaterial; // 조명이 켜졌을 때의 Material
    public Material offMaterial; // 조명이 꺼졌을 때의 Material
    public Light lightComponent; // 조명 컴포넌트
    public Renderer renderer; // Material을 변경할 Renderer 컴포넌트

    void Start()
    {
        
    }

    void Update()
    {
        if (lightComponent.enabled)
        {
            renderer.material = onMaterial; // 조명이 켜져 있을 때는 onMaterial로 Material 변경
        }
        else
        {
            renderer.material = offMaterial; // 조명이 꺼져 있을 때는 offMaterial로 Material 변경
        }
    }
}
