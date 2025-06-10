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
        //Ȯ���� 10%�� �α׿� '����'�� �̾Ҵ�!
        //Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        //������ 70% Ȯ���� 'ġġ'�� �̾ƹ��ȴ�!
        int randomValue = Random.Range(1, 101);

        Debug.Log($"������ ���� {randomValue}�Դϴ�.");
        // count 81

        if (count >= 8) // 1~10, 10%
        {
            Debug.Log("������ �̾Ҵ�!");
            Debug.Log($"������ ���� {randomValue}�Դϴ�.");
        }
        else if (randomValue <= 30) // 11~30, 20%
        {
            Debug.Log("�𳪸� �̾Ҵ�!");
            Debug.Log($"������ ���� {randomValue}�Դϴ�.");
        }
        else // 31~100, 70%
        {
            Debug.Log("ġġ�� �̾ƹ��ȴ�!");
            Debug.Log($"������ ���� {randomValue}�Դϴ�.");
        }
        */

        int randomValue2 = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100)
        int gachaCount = 0;
        int pickUpProbability = Random.Range(1, 3); // �Ⱦ� Ȯ���� ���� ����. (1~2, 50% Ȯ���� �Ⱦ��� ����)

        if (randomValue2 <= 10) // 1~10, 10%
        {
            
            if (1 >= pickUpProbability) // 1�̸� �Ϲ� S��, 2�̸� �Ⱦ� S��
            {
                Debug.Log("S���� �̾Ҵ�!");
                Debug.Log($"{randomValue2}, ��í Ƚ�� : {gachaCount}");
                gachaCount++;
            }
            else
            {
                Debug.Log("�Ⱦ� S���� �̾Ҵ�!");
                Debug.Log($"{randomValue2}, ��í Ƚ�� : {gachaCount}");
                gachaCount++;
            }
        }
        else if (randomValue2 <= 30) // 11~30, 20%
        {
            Debug.Log("A���� �̾Ҵ�!");
            Debug.Log($"{randomValue2}, ��í Ƚ�� : {gachaCount}");
            gachaCount++;
        }
        else if (randomValue2 <= 60) // 31~60, 30%
        {
            Debug.Log("B���� �̾Ҵ�!");
            Debug.Log($"{randomValue2}, ��í Ƚ�� : {gachaCount}");
            gachaCount++;
        }
        else // 61~100, 40%
        {
            Debug.Log("C���� �̾Ҵ�!");
            Debug.Log($"{randomValue2}, ��í Ƚ�� : {gachaCount}");
            gachaCount++;
        }

        /*
        for (int i = 0; i < 5; i++) // 0���� 4���� �ݺ����� �����Ѵ�. (5�� �ݺ�)
        {
            Debug.Log("�ݺ����� ����ƾ��!: "); //i = 0, 1, 2, 3, 4
        }
        */
    }

    /*
    public void Gacha()
    {
        // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        // ������ 70% Ȯ���� 'ġġ'�� �̾ƹ��ȴ�!

        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        Debug.Log($"������ ���� : {randomValue} �Դϴ�");
        // count 81
        if (count >= 8)
        {
            Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
            count = 0;
        }
        else if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'��û'�� �̾Ҵ�!");
        }
        else if (randomValue <= 30) // 11 ~ 30 -> 20%
        {
            Debug.Log("'��'�� �̾Ҵ�!");
        }
        else // 31 ~ 100 -> 70%
        {
            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
        }

        count++;
    }
    */

    public void Gacha_if()
    {
        // Ȯ���� 10%�� �α׿� '��û'�� �̾Ҵ�!
        // Ȯ���� 20%�� �α׿� '��'�� �̾Ҵ�!
        // ������ 70% Ȯ���� 'ġġ'�� �̾ƹ��ȴ�!

        int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

        Debug.Log($"������ ���� : {randomValue} �Դϴ�");
        // count 81
        if (count >= 8)
        {
            Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
            count = 0;
        }
        else if (randomValue <= 10) // 1 ~ 10 -> 10%
        {
            Debug.Log("'��û'�� �̾Ҵ�!");
        }
        else if (randomValue <= 30) // 11 ~ 30 -> 20%
        {
            Debug.Log("'��'�� �̾Ҵ�!");
        }
        else // 31 ~ 100 -> 70%
        {
            Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
        }

        count++;
    } // if�� ����

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
                Debug.Log("��û�� �̾Ҵ�!");
                Debug.Log(category);
                break;
            case 1:
                Debug.Log("�𳪸� �̾Ҵ�!");
                Debug.Log(category);
                break;
            case 2:
                Debug.Log("ġġ�� �̾ƹ��ȴ�!");
                Debug.Log(category);
                break;
        }
    } // Switch�� ����

    public void TenPullGacha()
    {
        for (int i = 0; i < 10; i++)
        {
            int randomValue = Random.Range(1, 101); // 1�̻� 101�̸��� ������ ���� �޾� ���ڴ�. (1 ~ 100) 

            Debug.Log($"������ ���� : {randomValue} �Դϴ�");
            if (count >= 8)
            {
                Debug.Log("Ȯ������ '��û'�� �̾Ҵ�!");
                count = 0;
            }
            else if (randomValue <= 10) // 1 ~ 10 -> 10%
            {
                Debug.Log("'��û'�� �̾Ҵ�!");
            }
            else if (randomValue <= 30) // 11 ~ 30 -> 20%
            {
                Debug.Log("'��'�� �̾Ҵ�!");
            }
            else // 31 ~ 100 -> 70%
            {
                Debug.Log("'ġġ'�� �̾ƹ��ȴ�!");
            }

            count++;
        }
    } // 10���� + õ�� �ڵ�

    public void IF_While() // if���� while���� �̿��� �ݺ��� ����
    {
        // [ for�� ]
        for(int i = 0; i < 10; i++) // ����, ����, �ݺ�
        {
            
        }

        // [ while�� ]
        int number = 0; //����
        while(number < 10) //����
        {
            number++; // �ݺ�
        }


    }

    /*
    [��ȭ]
    �� �ٿ� ����
    
    ������ �� 1~100 ���̿� ���� �����
    ������ ���⶧���� �ݺ��Ѵ�. //update������ �ϵ�? �Լ����� �ϵ�?
    inputField�� �Էµ� ����
    ������ ������ ũ�� "ũ��", ������ "�۴�"
    Count �����ؼ� ��� �õ��ߴ��� ��Ÿ���°͵� �ϰ�
    ��������� �� ������ ����Ĵ� �͵� ��Ÿ����
     */




    // Update is called once per frame
    void Update()
    {

    }
}
