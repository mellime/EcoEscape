using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Transform cameraTransform;   // 이동 방향을 카메라 기준으로 설정하기 위해 사용
    public CharacterController characterController; // CharacterController를 사용하여 3D 캐릭터 이동
    public float moveSpeed = 30f;   // 이동 속도
    public float gravity = -20f;    // 중력
    public float yVelocity = 0;     // Y축 속도


    // Start is called before the first frame update
    void Start()
    {
        yVelocity = 0; // Y축 속도 초기화
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 playerPosition = transform.position;

        Vector3 moveDirection = new Vector3(h, 0, v);

        moveDirection = cameraTransform.TransformDirection(moveDirection);  // 이동 방향
        moveDirection *= moveSpeed;

        moveDirection.y = yVelocity;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}