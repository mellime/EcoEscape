using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightMaterial : MonoBehaviour
{
    public Material onMaterial; // ������ ������ ���� Material
    public Material offMaterial; // ������ ������ ���� Material
    public Light lightComponent; // ���� ������Ʈ
    public Renderer renderer; // Material�� ������ Renderer ������Ʈ

    void Start()
    {
        
    }

    void Update()
    {
        if (lightComponent.enabled)
        {
            renderer.material = onMaterial; // ������ ���� ���� ���� onMaterial�� Material ����
        }
        else
        {
            renderer.material = offMaterial; // ������ ���� ���� ���� offMaterial�� Material ����
        }
    }
}
