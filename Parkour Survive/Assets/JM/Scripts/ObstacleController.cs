using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // �ڽ� ������Ʈ�� �ε��� �� ����Ǵ� �Լ�
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ��ü�� �÷��̾����� Ȯ��
        if (other.CompareTag("Player"))
        {
            // �ڽ� ������Ʈ�� ������ �ִ� �θ� ��ֹ��� ��Ȱ��ȭ
            transform.parent.gameObject.SetActive(false);
        }
    }
}