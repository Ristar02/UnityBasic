using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;



public class ControlFlow : MonoBehaviour
{
    int count;
    void Awake()
    {
        count = 0;
    }

    // Start is called before the first frame update
    
    
    void Start()
    {
        /*
        //확률이 10%면 로그에 '각정'을 뽑았다!
        //확률이 20%면 로그에 '모나'를 뽑았다!
        //나머지 70% 확률로 '치치'를 뽑아버렸다!
        int randomValue = Random.Range(1, 101);

        Debug.Log($"랜덤한 값은 {randomValue}입니다.");
        // count 81

        if (count >= 8) // 1~10, 10%
        {
            Debug.Log("각정을 뽑았다!");
            Debug.Log($"랜덤한 값은 {randomValue}입니다.");
        }
        else if (randomValue <= 30) // 11~30, 20%
        {
            Debug.Log("모나를 뽑았다!");
            Debug.Log($"랜덤한 값은 {randomValue}입니다.");
        }
        else // 31~100, 70%
        {
            Debug.Log("치치를 뽑아버렸다!");
            Debug.Log($"랜덤한 값은 {randomValue}입니다.");
        }
        */

        int randomValue2 = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100)
        int gachaCount = 0;
        int pickUpProbability = Random.Range(1, 3); // 픽업 확률을 위한 변수. (1~2, 50% 확률로 픽업이 나옴)

        if (randomValue2 <= 10) // 1~10, 10%
        {
            
            if (1 >= pickUpProbability) // 1이면 일반 S급, 2이면 픽업 S급
            {
                Debug.Log("S급을 뽑았다!");
                Debug.Log($"{randomValue2}, 가챠 횟수 : {gachaCount}");
                gachaCount++;
            }
            else
            {
                Debug.Log("픽업 S급을 뽑았다!");
                Debug.Log($"{randomValue2}, 가챠 횟수 : {gachaCount}");
                gachaCount++;
            }
        }
        else if (randomValue2 <= 30) // 11~30, 20%
        {
            Debug.Log("A급을 뽑았다!");
            Debug.Log($"{randomValue2}, 가챠 횟수 : {gachaCount}");
            gachaCount++;
        }
        else if (randomValue2 <= 60) // 31~60, 30%
        {
            Debug.Log("B급을 뽑았다!");
            Debug.Log($"{randomValue2}, 가챠 횟수 : {gachaCount}");
            gachaCount++;
        }
        else // 61~100, 40%
        {
            Debug.Log("C급을 뽑았다!");
            Debug.Log($"{randomValue2}, 가챠 횟수 : {gachaCount}");
            gachaCount++;
        }

        /*
        for (int i = 0; i < 5; i++) // 0부터 4까지 반복문을 실행한다. (5번 반복)
        {
            Debug.Log("반복문이 실행됐어요!: "); //i = 0, 1, 2, 3, 4
        }
        */
    }

    /*
    public void Gacha()
    {
        // 확률이 10%면 로그에 '각청'을 뽑았다!
        // 확률이 20%면 로그에 '모나'를 뽑았다!
        // 나머지 70% 확률로 '치치'를 뽑아버렸다!

        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        Debug.Log($"랜덤한 값은 : {randomValue} 입니다");
        // count 81
        if (count >= 8)
        {
            Debug.Log("확정으로 '각청'을 뽑았다!");
            count = 0;
        }
        else if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'각청'을 뽑았다!");
        }
        else if (randomValue <= 30) // 11 ~ 30 -> 20%
        {
            Debug.Log("'모나'을 뽑았다!");
        }
        else // 31 ~ 100 -> 70%
        {
            Debug.Log("'치치'를 뽑아버렸다!");
        }

        count++;
    }
    */

    public void Gacha_if()
    {
        // 확률이 10%면 로그에 '각청'을 뽑았다!
        // 확률이 20%면 로그에 '모나'를 뽑았다!
        // 나머지 70% 확률로 '치치'를 뽑아버렸다!

        int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

        Debug.Log($"랜덤한 값은 : {randomValue} 입니다");
        // count 81
        if (count >= 8)
        {
            Debug.Log("확정으로 '각청'을 뽑았다!");
            count = 0;
        }
        else if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'각청'을 뽑았다!");
        }
        else if (randomValue <= 30) // 11 ~ 30 -> 20%
        {
            Debug.Log("'모나'을 뽑았다!");
        }
        else // 31 ~ 100 -> 70%
        {
            Debug.Log("'치치'를 뽑아버렸다!");
        }

        count++;
    } // if문 설명

    public void Gacha_switch()
    {
        int randomValue = Random.Range(1, 101);
        int category;

        if (randomValue <= 10)
            category = 0;
        else if (randomValue <= 30)
            category = 1;
        else
            category = 2;

        switch (category)
        {
            case 0:
                Debug.Log("각청을 뽑았다!");
                Debug.Log(category);
                break;
            case 1:
                Debug.Log("모나를 뽑았다!");
                Debug.Log(category);
                break;
            case 2:
                Debug.Log("치치를 뽑아버렸다!");
                Debug.Log(category);
                break;
        }
    } // Switch문 설명

    public void TenPullGacha()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101); // 1이상 101미만의 랜덤한 값을 받아 오겠다. (1 ~ 100) 

            Debug.Log($"랜덤한 값은 : {randomValue} 입니다");
            if (count >= 8)
            {
                Debug.Log("확정으로 '각청'을 뽑았다!");
                count = 0;
            }
            else if (randomValue <= 10) // 1 ~ 10 -> 10%
            {
                Debug.Log("'각청'을 뽑았다!");
            }
            else if (randomValue <= 30) // 11 ~ 30 -> 20%
            {
                Debug.Log("'모나'을 뽑았다!");
            }
            else // 31 ~ 100 -> 70%
            {
                Debug.Log("'치치'를 뽑아버렸다!");
            }

            count++;
        }
    } // 10연차 + 천장 코드

    public void IF_While() // if문과 while문을 이용한 반복문 설명
    {
        // [ for문 ]
        for(int i = 0; i < 10; i++) // 변수, 조건, 반복
        {
            
        }

        // [ while문 ]
        int number = 0; //변수
        while(number < 10) //조건
        {
            number++; // 반복
        }


    }

    /*
    [심화]
    업 다운 게임
    
    랜덤한 수 1~100 사이에 값을 만들고
    정답을 맞출때까지 반복한다. //update문에서 하든? 함수에서 하든?
    inputField에 입력된 값이
    랜덤한 값보다 크면 "크다", 작으면 "작다"
    Count 증가해서 몇번 시도했는지 나타내는것도 하고
    결과적으로 몇 번만에 맞췄냐는 것도 나타내기
     */




    // Update is called once per frame
    void Update()
    {

    }
}
