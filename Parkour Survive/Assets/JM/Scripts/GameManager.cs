using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public TextMeshProUGUI scoreText;  // UI Text ������Ʈ�� ����

    private int score;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateScoreText();  // �ʱ� ���� �ؽ�Ʈ ������Ʈ
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();  // ������ ����� ������ �ؽ�Ʈ ������Ʈ
        Debug.Log("Current Score: " + score);
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public int GetScore()
    {
        return score;
    }
}