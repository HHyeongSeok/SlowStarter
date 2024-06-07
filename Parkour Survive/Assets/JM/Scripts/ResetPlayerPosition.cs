using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerPosition : MonoBehaviour
{
    // �÷��̾ �ǵ����� ��ġ
    public Transform resetPosition;

    private void OnTriggerEnter(Collider other)
    {
        // ���� �ٸ� collider�� "Player" ���̾�� �浹�ߴٸ�
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // �÷��̾��� ��ġ�� resetPosition���� ����
            other.transform.position = resetPosition.position;
        }
    }
}