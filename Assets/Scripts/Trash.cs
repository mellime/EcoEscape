using UnityEngine;

public class TrashObject : MonoBehaviour
{
    private Vector3 startPosition;

    void Start()
    {
        // 시작 위치 저장
        startPosition = transform.position;
    }

    public void ResetPosition()
    {
        // 원래 위치로 이동
        transform.position = startPosition;
    }
}