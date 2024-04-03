using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroy : MonoBehaviour
{
    // 충돌 감지 시 처리
    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 오브젝트의 레이어를 확인
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            // 충돌한 오브젝트의 부모 오브젝트를 파괴
            Destroy(transform.parent.gameObject);
            Debug.Log("Obstacle and its parent destroyed.");
        }
    }
}