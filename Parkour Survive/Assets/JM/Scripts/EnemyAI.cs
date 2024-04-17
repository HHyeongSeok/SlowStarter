using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform target; // 플레이어의 Transform을 할당하기 위한 변수
    public float moveSpeed = 3f; // 적의 이동 속도

    private Rigidbody rb; // Rigidbody 컴포넌트에 접근하기 위한 변수

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Rigidbody 컴포넌트를 가져옴
    }

    void Update()
    {
        if (target != null)
        {
            // 적이 플레이어 방향으로 이동하도록 함
            Vector3 moveDirection = (target.position - transform.position).normalized;
            rb.velocity = moveDirection * moveSpeed;

            // 적이 항상 플레이어를 향하도록 함
            transform.LookAt(target);
        }
    }

    void FixedUpdate()
    {
        // 매 프레임마다 플레이어의 위치를 쫓아가도록 함
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
    }
}