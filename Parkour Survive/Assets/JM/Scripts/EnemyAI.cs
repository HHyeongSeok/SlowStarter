using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform target; // �÷��̾��� Transform�� �Ҵ��ϱ� ���� ����
    public float moveSpeed = 3f; // ���� �̵� �ӵ�

    private Rigidbody rb; // Rigidbody ������Ʈ�� �����ϱ� ���� ����

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Rigidbody ������Ʈ�� ������
    }

    void Update()
    {
        if (target != null)
        {
            // ���� �÷��̾� �������� �̵��ϵ��� ��
            Vector3 moveDirection = (target.position - transform.position).normalized;
            rb.velocity = moveDirection * moveSpeed;

            // ���� �׻� �÷��̾ ���ϵ��� ��
            transform.LookAt(target);
        }
    }

    void FixedUpdate()
    {
        // �� �����Ӹ��� �÷��̾��� ��ġ�� �Ѿư����� ��
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            target = player.transform;
        }
    }
}