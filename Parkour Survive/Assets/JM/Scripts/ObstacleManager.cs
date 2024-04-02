using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public List<Transform> spawnPoints; // ���� ���� ���� ����Ʈ
    public GameObject obstaclePrefab; // ��ֹ� ������
    public float spawnInterval = 5f; // ���� ����

    private int currentSpawnIndex = 0; // ���� ���� �ε���
    private float timer = 0f;

    void Update()
    {
        // Ÿ�̸� ������Ʈ
        timer += Time.deltaTime;

        // ���� �ð� �������� ��ֹ� ����
        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        // ���� ���� �������� ��ֹ� ����
        Instantiate(obstaclePrefab, spawnPoints[currentSpawnIndex].position, Quaternion.identity);

        // ���� ���� ���� �ε����� �̵�
        currentSpawnIndex = (currentSpawnIndex + 1) % spawnPoints.Count;
    }
}