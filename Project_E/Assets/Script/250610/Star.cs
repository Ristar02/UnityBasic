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
        // string ������ ���� �ʱ�ȭ �մϴ�.
        string star;
        star = string.Empty;

        // 2. ��, ��ĭ, �ٹٲ� �߰��ϱ�
        // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
        star += "��"; // ��
        star += "��"; // ��ĭ
        star += "\n"; // �ٹٲ�

        // 3. Debug.Log("");
        // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
        Debug.Log(star);
    */

    public void Phase1() //���̾Ƹ�� ����
    {
        string star;
        star = string.Empty;

        for (int i = 0; i < 5; i++) // 5�� �ݺ�
        {
            for (int j = 0; j < i + 1; j++) // i + 1�� �ݺ�. i = 0�� �� 1��, i = 1�� �� 2��, ..., i = 4�� �� 5�� �ݺ�
            {
                star += "��"; // ��
            }
            if (i < 4) // ������ ���� �ƴ� ��
            {
                star += "\n"; // �ٹٲ�
            }
        }
        Debug.Log(star); // �ܼ�â�� ���
    }

    public void Phase2() //���̾Ƹ�� ���ϴ�
    {
        string star;
        star = string.Empty;

        for (int i = 0; i < 5; i++) // 5�� �ݺ�
        {
            for (int j = 0; j < i; j++) // i�� �ݺ�. i = 0�� �� 0��, i = 1�� �� 1��, ..., i = 4�� �� 4�� �ݺ�
            {
                star += "    "; // ��ĭ
            }
            for (int j = 0; j < 5 - i; j++) // 5-i�� �ݺ�. i = 0�� �� 5��, i = 1�� �� 4��, ..., i = 4�� �� 1�� �ݺ�
            {
                star += "��"; // ��
            }
            if (i < 4) // ������ ���� �ƴ� ��
            {
                star += "\n"; // �ٹٲ�
            }
        }
        Debug.Log(star); // �ܼ�â�� ���
    }

    public void Phase3() //���̾Ƹ�� ��
    {
        string star;
        star = string.Empty;

        for (int i = 0; i < 5; i++) // 5�� �ݺ�
        {
            for (int j = 0; j < i + 1; j++) // i + 1�� �ݺ�
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�. �� �ٹٲ� Ƚ���� 5��.
        }

        for (int i = 0; i < 4; i++) // 4�� �ݺ�. 
        {
            for (int j = 0; j < 4 - i; j++) // 4-i�� �ݺ�. i=0�� �� 4��, i=1�϶� 3�� ... i=3�� �� 1�� �ݺ�
            {
                star += "��"; // ��
            }
            if (i < 3) // ������ ���� �ƴ� ��
            {
                star += "\n"; // �ٹٲ�
            }
        }
        Debug.Log(star); // �ܼ�â�� ���
    }

    public void Phase4() //���̾Ƹ�� ��
    {
        string star;
        star = string.Empty;

        for (int i = 0; i < 5; i++) // 5�� �ݺ�
        {
            for (int j = 0; j < 4 - i; j++) // 4-i�� �ݺ�. i=0�� �� 4��, i=1�� �� 3��, ..., i=4�� �� 0�� �ݺ�
            {
                star += "    "; // ��ĭ
            }
            for (int j = 0; j < i + 1; j++) // i + 1�� �ݺ�. i=0�� �� 1��, i=1�� �� 2��, ..., i=4�� �� 5�� �ݺ�
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�. �� �ٹٲ� Ƚ���� 5��.
        }

        for (int i = 0; i < 4; i++) // 4�� �ݺ�
        {
            for (int j = 0; j < i + 1; j++) // i + 1�� �ݺ�. i=0�� �� 1��, i=2�� �� 2��, ..., i=3�� �� 4�� �ݺ�
            {
                star += "    "; // ��ĭ
            }
            for (int j = 0; j < 4 - i; j++) // 3-i�� �ݺ�. i=0�� �� 4��, i=1�� �� 3��, ..., i=3�� �� 1�� �ݺ�
            {
                star += "��"; // ��
            }
            if (1 < 3) // ������ ���� �ƴ� ��
            {
                star += "\n"; // �ٹٲ�
            }
        }
        Debug.Log(star); // �ܼ�â�� ���
    }

    public void Phase5() //���̾Ƹ��
    {
        string star;
        star = string.Empty;

        for (int i = 0; i < 5; i++) // 5�� �ݺ�
        {
            for (int j = 0; j < 4 - i; j++) // 4-i�� �ݺ�. i=0�� �� 4��, i=1�� �� 3��, ..., i=4�� �� 0�� �ݺ�
            {
                star += "    ";  // ��ĭ
            }
            for (int j = 0; j < 2*i + 1; j++)  // 2*i + 1�� �ݺ�. i=0�� �� 1��, i=1�� �� 3��, ..., i=4�� �� 9�� �ݺ�
            {
                star += "��"; // ��
            }
            star += "\n"; // �ٹٲ�. �� �ٹٲ� Ƚ���� 5��.
        }

        for (int i = 0; i < 4; i++) // 4�� �ݺ�
        {
            for (int j = 0; j < i + 1; j++) // i + 1�� �ݺ�. i=0�� �� 1��, i=1�� �� 2��, ..., i=3�� �� 4�� �ݺ�
            {
                star += "    "; // ��ĭ
            }
            for (int j = 0; j < 7 - 2*i; j++) // 7 - 2*i�� �ݺ�. i=0�� �� 7��, i=1�� �� 5��, ..., i=3�� �� 1�� �ݺ�
            {
                star += "��"; // ��
            }
            if (i < 3) // ������ ���� �ƴ� ��
            {
                star += "\n"; // �ٹٲ�
            }
        }
        Debug.Log(star); // �ܼ�â�� ���
    }


}
