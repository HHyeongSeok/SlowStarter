using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float maxHP = 100f;   // 플레이어의 최대 HP
    private float currentHP;     // 현재 HP
    public float hpDecreaseRate = 1f;  // HP가 감소하는 속도 (초당 감소량)

    public Slider hpSlider;      // HP를 표시할 Slider UI
    public GameObject gameOverPanel;  // 게임 오버 패널

    private bool isGameOver = false;  // 게임 오버 상태

    void Start()
    {
        // 초기 HP 설정
        currentHP = maxHP;

        // 슬라이더의 최대값 설정
        hpSlider.maxValue = maxHP;
        hpSlider.value = currentHP; // 슬라이더의 현재값도 초기화

        // 게임 오버 패널 비활성화
        gameOverPanel.SetActive(false);

        // 게임 시간 정상화
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!isGameOver)
        {
            // 시간에 따라 HP 감소
            currentHP -= hpDecreaseRate * Time.deltaTime;

            // HP가 0 이하가 되면 게임 오버 처리
            if (currentHP <= 0)
            {
                currentHP = 0;
                GameOver();
            }

            // 슬라이더 값 업데이트
            UpdateHPSlider();
        }
    }

    // HP를 추가하거나 회복하는 메소드
    public void AddHP(float amount)
    {
        if (!isGameOver)
        {
            currentHP += amount;
            if (currentHP > maxHP)
            {
                currentHP = maxHP;
            }
            UpdateHPSlider();
        }
    }

    // 외부에서 슬라이더 값을 직접 조정하는 메소드
    public void IncreaseSliderValue(float amount)
    {
        if (!isGameOver)
        {
            hpSlider.value += amount;
            if (hpSlider.value > maxHP)
            {
                hpSlider.value = maxHP;
            }
        }
    }

    // 현재 HP를 슬라이더에 업데이트하는 메소드
    private void UpdateHPSlider()
    {
        hpSlider.value = currentHP;
    }

    // 게임 오버 처리 메소드
    private void GameOver()
    {
        isGameOver = true;

        // 게임 오버 패널 활성화
        gameOverPanel.SetActive(true);

        // 게임 시간 정지
        Time.timeScale = 0;
    }
}