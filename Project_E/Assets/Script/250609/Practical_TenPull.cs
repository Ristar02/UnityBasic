using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class Practical_TenPull : MonoBehaviour
{
    public TextMeshProUGUI resultText;

    //List로 3성, 4성, 5성 캐릭터를 만들어봅시다.
    public void TenPull()
    {
        List<string> characterList = new List<string>();
        characterList.Add("3성"); // 0번
        characterList.Add("4성"); // 1번
        characterList.Add("5성"); // 2번

        Random.Range(1, 101); // 1부터 100까지의 랜덤한 값을 받아온다.
        int randomValue = Random.Range(1, 101); // 1 ~ 100
        int tenCount = 0; // 10연차 까지 뽑은 횟수

        for (int i = 0; i < 10; i++) // i는 0부터 9까지 반복문을 실행한다. (10번 반복)
        {
            tenCount += 1; // 뽑은 횟수를 1씩 증가시킨다.

            if (tenCount >= 10) // 뽑은 횟수가 10이상이면
            {
                resultText.text = $"확정 {characterList[2]}"; // UI에 확정 5성 캐릭터를 뽑았다고 출력한다.
                Debug.Log($"확정 {characterList[2]} 캐릭터를 뽑았습니다!"); // 로그에 확정 5성 캐릭터를 뽑았다고 출력한다.
                tenCount = 0; // 뽑은 횟수를 초기화한다.
                break; // 반복문을 종료한다.
            }
            else if (randomValue <= 10)
            {
                resultText.text = $"{characterList[2]}"; // UI에 확정 5성 캐릭터를 뽑았다고 출력한다.
                Debug.Log($"{characterList[2]} 캐릭터를 뽑았습니다!"); // 10% 확률로 5성 캐릭터를 뽑았다고 출력한다.
            }
            else if (randomValue <= 40)
            {
                resultText.text = $"{characterList[1]}";
                Debug.Log($"{characterList[1]} 캐릭터를 뽑았습니다!"); // 30% 확률로 4성 캐릭터를 뽑았다고 출력한다.
            }
            else
            {
                resultText.text = $"{characterList[0]}";
                Debug.Log($"{characterList[0]} 캐릭터를 뽑았습니다!"); // 나머지 60% 확률로 3성 캐릭터를 뽑았다고 출력한다.
            }
        }
    }
}