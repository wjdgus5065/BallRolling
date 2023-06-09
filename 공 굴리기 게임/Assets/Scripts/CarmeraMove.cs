using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 카메라가 플레이어를 따라갈 수 있게 구현
public class CarmeraMove : MonoBehaviour
{
    Transform playerTransform;
    Vector3 Offset;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransform.position;   
    }

    void LateUpdate()
    {
        transform.position = playerTransform.position + Offset;
    }
}
