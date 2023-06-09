using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ī�޶� �÷��̾ ���� �� �ְ� ����
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
