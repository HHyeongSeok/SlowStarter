using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI ���ӽ����̽� �߰�

public class ObstacleController : MonoBehaviour
{
    public int scoreValue = 10;
    public float hpIncreaseAmount = 10f;  // �浹 �� ������ HP ��

    // �ڽ� ������Ʈ�� �ε��� �� ����Ǵ� �Լ�
    private void OnTriggerEnter(Collider other)
    {
        // �浹�� ��ü�� �÷��̾����� Ȯ��
        if (other.CompareTag("Player"))
        {
            // ���� �߰�
            GameManager.Instance.AddScore(scoreValue);

            // �÷��̾��� Player ��ũ��Ʈ�� ������
            Player player = other.GetComponent<Player>();

            // �÷��̾ �����ϰ�, Player ��ũ��Ʈ�� �����ϴ� ���
            if (player != null)
            {
                // HP �����̴� �� ����
                player.IncreaseSliderValue(hpIncreaseAmount);
            }

            // �ڽ� ������Ʈ�� ������ �ִ� �θ� ��ֹ��� �ı�
            Destroy(transform.parent.gameObject);
        }
    }
}