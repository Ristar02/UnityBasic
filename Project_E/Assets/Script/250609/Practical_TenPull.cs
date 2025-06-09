using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class Practical_TenPull : MonoBehaviour
{
    public TextMeshProUGUI resultText;

    //List�� 3��, 4��, 5�� ĳ���͸� �����ô�.
    public void TenPull()
    {
        List<string> characterList = new List<string>();
        characterList.Add("3��"); // 0��
        characterList.Add("4��"); // 1��
        characterList.Add("5��"); // 2��

        Random.Range(1, 101); // 1���� 100������ ������ ���� �޾ƿ´�.
        int randomValue = Random.Range(1, 101); // 1 ~ 100
        int tenCount = 0; // 10���� ���� ���� Ƚ��

        for (int i = 0; i < 10; i++) // i�� 0���� 9���� �ݺ����� �����Ѵ�. (10�� �ݺ�)
        {
            tenCount += 1; // ���� Ƚ���� 1�� ������Ų��.

            if (tenCount >= 10) // ���� Ƚ���� 10�̻��̸�
            {
                resultText.text = $"Ȯ�� {characterList[2]}"; // UI�� Ȯ�� 5�� ĳ���͸� �̾Ҵٰ� ����Ѵ�.
                Debug.Log($"Ȯ�� {characterList[2]} ĳ���͸� �̾ҽ��ϴ�!"); // �α׿� Ȯ�� 5�� ĳ���͸� �̾Ҵٰ� ����Ѵ�.
                tenCount = 0; // ���� Ƚ���� �ʱ�ȭ�Ѵ�.
                break; // �ݺ����� �����Ѵ�.
            }
            else if (randomValue <= 10)
            {
                resultText.text = $"{characterList[2]}"; // UI�� Ȯ�� 5�� ĳ���͸� �̾Ҵٰ� ����Ѵ�.
                Debug.Log($"{characterList[2]} ĳ���͸� �̾ҽ��ϴ�!"); // 10% Ȯ���� 5�� ĳ���͸� �̾Ҵٰ� ����Ѵ�.
            }
            else if (randomValue <= 40)
            {
                resultText.text = $"{characterList[1]}";
                Debug.Log($"{characterList[1]} ĳ���͸� �̾ҽ��ϴ�!"); // 30% Ȯ���� 4�� ĳ���͸� �̾Ҵٰ� ����Ѵ�.
            }
            else
            {
                resultText.text = $"{characterList[0]}";
                Debug.Log($"{characterList[0]} ĳ���͸� �̾ҽ��ϴ�!"); // ������ 60% Ȯ���� 3�� ĳ���͸� �̾Ҵٰ� ����Ѵ�.
            }
        }
    }
}