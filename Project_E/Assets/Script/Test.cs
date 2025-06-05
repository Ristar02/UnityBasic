using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

/*
public class Person
{
    public string myName;
    public int myAge;
    public string myBirthday;
    public int myHeight;
    public string myMbti;
    public string myBloodType;
    public string myHometown;
    public string myHobby;
    public string myEmail;
    public string myPhoneNumber;
    public string myMajor;

    public void Introduce()
    {
        Debug.Log("저의 이름은 " + myName + "입니다.");
        Debug.Log($"저의 나이는 {myAge}살 입니다.");
        Debug.Log($"저의 생일은 {myBirthday}입니다.");
        Debug.Log($"저의 키는 {myHeight}cm 입니다.");
        Debug.Log($"저의 MBTI는 {myMbti}입니다.");
        Debug.Log($"저의 혈액형은 {myBloodType}입니다.");
        Debug.Log($"저의 고향은 {myHometown}입니다.");
        Debug.Log($"저의 취미는 {myHobby}입니다.");
        Debug.Log($"저의 이메일은 {myEmail}입니다.");
        Debug.Log($"저의 전화번호는 {myPhoneNumber}입니다.");
        Debug.Log($"저의 전공은 {myMajor}입니다.");
    }
}
*/
public class Test : MonoBehaviour
{
    
    /*
    private Person[] people;

    void Start()
    {
        people = new Person[3];

        people[0] = new Person { myName = "이창호", myAge = 27, myHeight = 165 };
        people[1] = new Person { myName = "김철수", myAge = 30, myHeight = 180 };
        people[2] = new Person { myName = "박영희", myAge = 25, myHeight = 160 };

        foreach (Person p in people)
        {
            p.Introduce();
        }
    }
    */
    

    private string myName = "이창호";
    private int myAge = 27;
    private string myBirthday = "1999년 7월 30일";
    private int myHeight = 165;
    private string myMbti = "INFP";
    private string myBloodType = "B형";
    private string myHometown = "대전";
    private string myHobby = "게임";
    private string myEmail = "ch99730@gmail.com";
    private string myPhoneNumber = "010-1234-5678";
    private string myMajor = "전자공학과";

    void Start()
    {
        SelfIntroduction();
        SelfIntroduction(myName, myAge, myHeight, myMbti);


        //1 이상 7 미만의 정수를 랜덤으로 출력합니다.
        //Debug.Log(Random.Range(1, 7));
    }

    public void SelfIntroduction()
    {
        Debug.Log("저의 이름은 " + myName + "입니다.");
        Debug.Log($"저의 나이는 {myAge}살 입니다.");
        Debug.Log($"저의 생일은 {myBirthday}입니다.");
        Debug.Log($"저의 키는 {myHeight}cm 입니다.");
        Debug.Log($"저의 MBTI는 {myMbti}입니다.");
        Debug.Log($"저의 혈액형은 {myBloodType}입니다.");
        Debug.Log($"저의 고향은 {myHometown}입니다.");
        Debug.Log($"저의 취미는 {myHobby}입니다.");
        Debug.Log($"저의 이메일은 {myEmail}입니다.");
        Debug.Log($"저의 전화번호는 {myPhoneNumber}입니다.");
        Debug.Log($"저의 전공은 {myMajor}입니다.");

    }

    public void SelfIntroduction(string _myName, int _myAge, int _myHeight, string _myMbti)
    {
        Debug.Log("저의 이름은" + _myName + "입니다.");
        Debug.Log($"저의 나이는 {_myAge}살 입니다.");
    }
    

}