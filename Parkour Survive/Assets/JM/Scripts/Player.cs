using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float maxHP = 100f;   // �÷��̾��� �ִ� HP
    private float currentHP;     // ���� HP
    public float hpDecreaseRate = 1f;  // HP�� �����ϴ� �ӵ� (�ʴ� ���ҷ�)

    public Slider hpSlider;      // HP�� ǥ���� Slider UI
    public GameObject gameOverPanel;  // ���� ���� �г�

    private bool isGameOver = false;  // ���� ���� ����

    void Start()
    {
        // �ʱ� HP ����
        currentHP = maxHP;

        // �����̴��� �ִ밪 ����
        hpSlider.maxValue = maxHP;
        hpSlider.value = currentHP; // �����̴��� ���簪�� �ʱ�ȭ

        // ���� ���� �г� ��Ȱ��ȭ
        gameOverPanel.SetActive(false);

        // ���� �ð� ����ȭ
        Time.timeScale = 1;
    }

    void Update()
    {
        if (!isGameOver)
        {
            // �ð��� ���� HP ����
            currentHP -= hpDecreaseRate * Time.deltaTime;

            // HP�� 0 ���ϰ� �Ǹ� ���� ���� ó��
            if (currentHP <= 0)
            {
                currentHP = 0;
                GameOver();
            }

            // �����̴� �� ������Ʈ
            UpdateHPSlider();
        }
    }

    // HP�� �߰��ϰų� ȸ���ϴ� �޼ҵ�
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

    // �ܺο��� �����̴� ���� ���� �����ϴ� �޼ҵ�
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

    // ���� HP�� �����̴��� ������Ʈ�ϴ� �޼ҵ�
    private void UpdateHPSlider()
    {
        hpSlider.value = currentHP;
    }

    // ���� ���� ó�� �޼ҵ�
    private void GameOver()
    {
        isGameOver = true;

        // ���� ���� �г� Ȱ��ȭ
        gameOverPanel.SetActive(true);

        // ���� �ð� ����
        Time.timeScale = 0;
    }
}