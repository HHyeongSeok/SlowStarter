using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public GameObject clearPanel; // Ŭ���� �г��� ������ public ����
    public LayerMask playerLayer; // �÷��̾� ���̾ �����ϱ� ���� LayerMask

    private void OnTriggerEnter(Collider other)
    {
        // �÷��̾� ���̾����� Ȯ��
        if (((1 << other.gameObject.layer) & playerLayer) != 0)
        {
            clearPanel.SetActive(true); // Ŭ���� �г� Ȱ��ȭ
        }
    }
}