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
        Debug.Log("���� �̸��� " + myName + "�Դϴ�.");
        Debug.Log($"���� ���̴� {myAge}�� �Դϴ�.");
        Debug.Log($"���� ������ {myBirthday}�Դϴ�.");
        Debug.Log($"���� Ű�� {myHeight}cm �Դϴ�.");
        Debug.Log($"���� MBTI�� {myMbti}�Դϴ�.");
        Debug.Log($"���� �������� {myBloodType}�Դϴ�.");
        Debug.Log($"���� ������ {myHometown}�Դϴ�.");
        Debug.Log($"���� ��̴� {myHobby}�Դϴ�.");
        Debug.Log($"���� �̸����� {myEmail}�Դϴ�.");
        Debug.Log($"���� ��ȭ��ȣ�� {myPhoneNumber}�Դϴ�.");
        Debug.Log($"���� ������ {myMajor}�Դϴ�.");
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

        people[0] = new Person { myName = "��âȣ", myAge = 27, myHeight = 165 };
        people[1] = new Person { myName = "��ö��", myAge = 30, myHeight = 180 };
        people[2] = new Person { myName = "�ڿ���", myAge = 25, myHeight = 160 };

        foreach (Person p in people)
        {
            p.Introduce();
        }
    }
    */
    

    private string myName = "��âȣ";
    private int myAge = 27;
    private string myBirthday = "1999�� 7�� 30��";
    private int myHeight = 165;
    private string myMbti = "INFP";
    private string myBloodType = "B��";
    private string myHometown = "����";
    private string myHobby = "����";
    private string myEmail = "ch99730@gmail.com";
    private string myPhoneNumber = "010-1234-5678";
    private string myMajor = "���ڰ��а�";

    void Start()
    {
        SelfIntroduction();
        SelfIntroduction(myName, myAge, myHeight, myMbti);


        //1 �̻� 7 �̸��� ������ �������� ����մϴ�.
        //Debug.Log(Random.Range(1, 7));
    }

    public void SelfIntroduction()
    {
        Debug.Log("���� �̸��� " + myName + "�Դϴ�.");
        Debug.Log($"���� ���̴� {myAge}�� �Դϴ�.");
        Debug.Log($"���� ������ {myBirthday}�Դϴ�.");
        Debug.Log($"���� Ű�� {myHeight}cm �Դϴ�.");
        Debug.Log($"���� MBTI�� {myMbti}�Դϴ�.");
        Debug.Log($"���� �������� {myBloodType}�Դϴ�.");
        Debug.Log($"���� ������ {myHometown}�Դϴ�.");
        Debug.Log($"���� ��̴� {myHobby}�Դϴ�.");
        Debug.Log($"���� �̸����� {myEmail}�Դϴ�.");
        Debug.Log($"���� ��ȭ��ȣ�� {myPhoneNumber}�Դϴ�.");
        Debug.Log($"���� ������ {myMajor}�Դϴ�.");

    }

    public void SelfIntroduction(string _myName, int _myAge, int _myHeight, string _myMbti)
    {
        Debug.Log("���� �̸���" + _myName + "�Դϴ�.");
        Debug.Log($"���� ���̴� {_myAge}�� �Դϴ�.");
    }
    

}