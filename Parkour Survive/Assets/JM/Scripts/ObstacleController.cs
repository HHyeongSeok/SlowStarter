using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI ���ӽ����̽� �߰�

public class ObstacleController : MonoBehaviour
{
    public int scoreValue = 10;

    // �ڽ� ������Ʈ�� �ε��� �� ����Ǵ� �Լ�
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ��ü�� �÷��̾����� Ȯ��
        if (other.CompareTag("Player"))
        {
            Destroy(transform.parent.gameObject);
            GameManager.Instance.AddScore(scoreValue);
        }
    }
}