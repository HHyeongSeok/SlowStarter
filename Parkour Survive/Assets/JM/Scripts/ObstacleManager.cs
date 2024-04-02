using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public List<Transform> spawnPoints; // 여러 스폰 지점 리스트
    public GameObject obstaclePrefab; // 장애물 프리팹
    public float spawnInterval = 5f; // 생성 간격

    private int currentSpawnIndex = 0; // 현재 스폰 인덱스
    private float timer = 0f;

    void Update()
    {
        // 타이머 업데이트
        timer += Time.deltaTime;

        // 일정 시간 간격으로 장애물 생성
        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        // 현재 스폰 지점에서 장애물 생성
        Instantiate(obstaclePrefab, spawnPoints[currentSpawnIndex].position, Quaternion.identity);

        // 다음 스폰 지점 인덱스로 이동
        currentSpawnIndex = (currentSpawnIndex + 1) % spawnPoints.Count;
    }
}