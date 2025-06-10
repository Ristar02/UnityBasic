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
        UpdateCountText(); // 처음 시도 횟수 표시
        scrollLogText.text = ""; // 초기화
    }

    void CheckGuess()
    {
        if (int.TryParse(inputField.text, out int guess))
        {
            if (guess < 1 || guess > 100)
            {
                resultText.text = "1~100 사이의 숫자를 입력하세요.";
                AddLog("1~100 사이의 숫자를 입력하세요.");
                return;
            }

            tryCount++; // 카운트 증가
            UpdateCountText();

            if (guess < randomValue)
            {
                resultText.text = $"입력한 값: {inputField.text} / 업";
                AddLog($"입력한 값: {guess} / 업");
            }
            else if (guess > randomValue)
            {
                resultText.text = $"입력한 값: {inputField.text} / 다운";
                AddLog($"입력한 값: {guess} / 다운");
            }
            else
            {
                resultText.text = $"입력한 값: {inputField.text} / 정답! 시도 횟수: {tryCount}번";
                AddLog($"입력한 값: {guess} / 정답! 시도 횟수: {tryCount}번");
            }
        }
        else
        {
            resultText.text = "유효한 숫자를 입력하세요.";
        }
    }

    void UpdateCountText()
    {
        countText.text = $"시도 횟수: {tryCount}번";
    }

    void AddLog(string message)
    {
        scrollLogText.text += message + "\n"; // 로그 누적
    }
}