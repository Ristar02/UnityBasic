using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    /*
        // 1. string.Empty
        // string 변수의 값을 초기화 합니다.
        string star;
        star = string.Empty;

        // 2. 별, 빈칸, 줄바꿈 추가하기
        // Debug.Log를 사용하여 콘솔창에 출력합니다
        star += "★"; // 별
        star += "　"; // 빈칸
        star += "\n"; // 줄바꿈

        // 3. Debug.Log("");
        // Debug.Log를 사용하여 콘솔창에 출력합니다
        Debug.Log(star);
    */

    public void Phase1() //다이아몬드 우상단
    {
        string star;
        star = string.Empty;

        for (int i = 0; i < 5; i++) // 5번 반복
        {
            for (int j = 0; j < i + 1; j++) // i + 1번 반복. i = 0일 때 1번, i = 1일 때 2번, ..., i = 4일 때 5번 반복
            {
                star += "★"; // 별
            }
            if (i < 4) // 마지막 줄이 아닐 때
            {
                star += "\n"; // 줄바꿈
            }
        }
        Debug.Log(star); // 콘솔창에 출력
    }

    public void Phase2() //다이아몬드 좌하단
    {
        string star;
        star = string.Empty;

        for (int i = 0; i < 5; i++) // 5번 반복
        {
            for (int j = 0; j < i; j++) // i번 반복. i = 0일 때 0번, i = 1일 때 1번, ..., i = 4일 때 4번 반복
            {
                star += "    "; // 빈칸
            }
            for (int j = 0; j < 5 - i; j++) // 5-i번 반복. i = 0일 때 5번, i = 1일 때 4번, ..., i = 4일 때 1번 반복
            {
                star += "★"; // 별
            }
            if (i < 4) // 마지막 줄이 아닐 때
            {
                star += "\n"; // 줄바꿈
            }
        }
        Debug.Log(star); // 콘솔창에 출력
    }

    public void Phase3() //다이아몬드 우
    {
        string star;
        star = string.Empty;

        for (int i = 0; i < 5; i++) // 5번 반복
        {
            for (int j = 0; j < i + 1; j++) // i + 1번 반복
            {
                star += "★"; // 별
            }
            star += "\n"; // 줄바꿈. 총 줄바꿈 횟수는 5번.
        }

        for (int i = 0; i < 4; i++) // 4번 반복. 
        {
            for (int j = 0; j < 4 - i; j++) // 4-i번 반복. i=0일 때 4번, i=1일때 3번 ... i=3일 때 1번 반복
            {
                star += "★"; // 별
            }
            if (i < 3) // 마지막 줄이 아닐 때
            {
                star += "\n"; // 줄바꿈
            }
        }
        Debug.Log(star); // 콘솔창에 출력
    }

    public void Phase4() //다이아몬드 좌
    {
        string star;
        star = string.Empty;

        for (int i = 0; i < 5; i++) // 5번 반복
        {
            for (int j = 0; j < 4 - i; j++) // 4-i번 반복. i=0일 때 4번, i=1일 때 3번, ..., i=4일 때 0번 반복
            {
                star += "    "; // 빈칸
            }
            for (int j = 0; j < i + 1; j++) // i + 1번 반복. i=0일 때 1번, i=1일 때 2번, ..., i=4일 때 5번 반복
            {
                star += "★"; // 별
            }
            star += "\n"; // 줄바꿈. 총 줄바꿈 횟수는 5번.
        }

        for (int i = 0; i < 4; i++) // 4번 반복
        {
            for (int j = 0; j < i + 1; j++) // i + 1번 반복. i=0일 때 1번, i=2일 때 2번, ..., i=3일 때 4번 반복
            {
                star += "    "; // 빈칸
            }
            for (int j = 0; j < 4 - i; j++) // 3-i번 반복. i=0일 때 4번, i=1일 때 3번, ..., i=3일 때 1번 반복
            {
                star += "★"; // 별
            }
            if (1 < 3) // 마지막 줄이 아닐 때
            {
                star += "\n"; // 줄바꿈
            }
        }
        Debug.Log(star); // 콘솔창에 출력
    }

    public void Phase5() //다이아몬드
    {
        string star;
        star = string.Empty;

        for (int i = 0; i < 5; i++) // 5번 반복
        {
            for (int j = 0; j < 4 - i; j++) // 4-i번 반복. i=0일 때 4번, i=1일 때 3번, ..., i=4일 때 0번 반복
            {
                star += "    ";  // 빈칸
            }
            for (int j = 0; j < 2*i + 1; j++)  // 2*i + 1번 반복. i=0일 때 1번, i=1일 때 3번, ..., i=4일 때 9번 반복
            {
                star += "★"; // 별
            }
            star += "\n"; // 줄바꿈. 총 줄바꿈 횟수는 5번.
        }

        for (int i = 0; i < 4; i++) // 4번 반복
        {
            for (int j = 0; j < i + 1; j++) // i + 1번 반복. i=0일 때 1번, i=1일 때 2번, ..., i=3일 때 4번 반복
            {
                star += "    "; // 빈칸
            }
            for (int j = 0; j < 7 - 2*i; j++) // 7 - 2*i번 반복. i=0일 때 7번, i=1일 때 5번, ..., i=3일 때 1번 반복
            {
                star += "★"; // 별
            }
            if (i < 3) // 마지막 줄이 아닐 때
            {
                star += "\n"; // 줄바꿈
            }
        }
        Debug.Log(star); // 콘솔창에 출력
    }


}
