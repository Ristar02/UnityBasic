using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text resultText;
    public TMP_Text countText;
    public Button checkButton;
    public TMP_Text scrollLogText;

    private int randomValue;
    private int tryCount = 0;

    void Start()
    {
        randomValue = Random.Range(1, 101);
        checkButton.onClick.AddListener(CheckGuess);
        UpdateCountText(); // ó�� �õ� Ƚ�� ǥ��
        scrollLogText.text = ""; // �ʱ�ȭ
    }

    void CheckGuess()
    {
        if (int.TryParse(inputField.text, out int guess))
        {
            if (guess < 1 || guess > 100)
            {
                resultText.text = "1~100 ������ ���ڸ� �Է��ϼ���.";
                AddLog("1~100 ������ ���ڸ� �Է��ϼ���.");
                return;
            }

            tryCount++; // ī��Ʈ ����
            UpdateCountText();

            if (guess < randomValue)
            {
                resultText.text = $"�Է��� ��: {inputField.text} / ��";
                AddLog($"�Է��� ��: {guess} / ��");
            }
            else if (guess > randomValue)
            {
                resultText.text = $"�Է��� ��: {inputField.text} / �ٿ�";
                AddLog($"�Է��� ��: {guess} / �ٿ�");
            }
            else
            {
                resultText.text = $"�Է��� ��: {inputField.text} / ����! �õ� Ƚ��: {tryCount}��";
                AddLog($"�Է��� ��: {guess} / ����! �õ� Ƚ��: {tryCount}��");
            }
        }
        else
        {
            resultText.text = "��ȿ�� ���ڸ� �Է��ϼ���.";
        }
    }

    void UpdateCountText()
    {
        countText.text = $"�õ� Ƚ��: {tryCount}��";
    }

    void AddLog(string message)
    {
        scrollLogText.text += message + "\n"; // �α� ����
    }
}